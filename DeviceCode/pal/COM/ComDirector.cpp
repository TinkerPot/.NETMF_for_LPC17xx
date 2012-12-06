////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Microsoft Corporation.  All rights reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#include <tinyhal.h>

//////////////////////////////////////////////////////////////////////////////////

BOOL DebuggerPort_Initialize( COM_HANDLE ComPortNum )
{
    NATIVE_PROFILE_PAL_COM();
    switch(ExtractTransport(ComPortNum))
    {
        case USART_TRANSPORT:
            return USART_Initialize( ConvertCOM_ComPort(ComPortNum), HalSystemConfig.USART_DefaultBaudRate, USART_PARITY_NONE, 8, USART_STOP_BITS_ONE, USART_FLOW_NONE );
        case USB_TRANSPORT:
            if(USB_CONFIG_ERR_OK != USB_Configure( ConvertCOM_UsbController(ComPortNum), NULL )) return FALSE;
            if(!USB_Initialize( ConvertCOM_UsbController(ComPortNum) ))                          return FALSE;
            return USB_OpenStream( ConvertCOM_UsbStream(ComPortNum), USB_DEBUG_EP_WRITE, USB_DEBUG_EP_READ );
        case SOCKET_TRANSPORT:
            return SOCKETS_Initialize(ConvertCOM_SockPort(ComPortNum));
    }

    return FALSE;
}

BOOL DebuggerPort_Uninitialize( COM_HANDLE ComPortNum )
{
    NATIVE_PROFILE_PAL_COM();
    switch(ExtractTransport(ComPortNum))
    {
        case USART_TRANSPORT:
            return USART_Uninitialize( ConvertCOM_ComPort(ComPortNum) );
        case USB_TRANSPORT:
            USB_CloseStream( ConvertCOM_UsbStream(ComPortNum) );
            return USB_Uninitialize( ConvertCOM_UsbController(ComPortNum) );
        case SOCKET_TRANSPORT:
            return SOCKETS_Uninitialize(ConvertCOM_SockPort(ComPortNum));
    }

    return FALSE;
}

int DebuggerPort_Write( COM_HANDLE ComPortNum, const char* Data, size_t size )
{
    NATIVE_PROFILE_PAL_COM();
    
    UINT32       transport = ExtractTransport(ComPortNum);
    const char*  dataTmp   = Data;
    INT32        totWrite  = 0;
    int          retries   = 100;

    while(size > 0 && retries--)
    {
        int ret = 0;
        
        switch(transport)
        {
            case USART_TRANSPORT:
                ret = USART_Write( ConvertCOM_ComPort( ComPortNum ), dataTmp, size );
                break;
            case USB_TRANSPORT:
                ret = USB_Write( ConvertCOM_UsbStream( ComPortNum ), dataTmp, size );
                break;
            case SOCKET_TRANSPORT:
                ret = SOCKETS_Write( ConvertCOM_SockPort(ComPortNum), dataTmp, size );
                break;
        }
        if(ret < 0)
        {
            break;
        }
        else if(ret == 0)
        {
            // if interrupts are off and our buffer is full then there is nothing we can do
            if(!INTERRUPTS_ENABLED_STATE()) break;

            Events_WaitForEvents(0, 1);
        }
        else
        {
            retries   = 50;   // reset retries
            size     -= ret;
            dataTmp  += ret;
            totWrite += ret;
        }
    }

    return totWrite;
}


int DebuggerPort_Read( COM_HANDLE ComPortNum, char* Data, size_t size )
{
    NATIVE_PROFILE_PAL_COM();
    int ret = 0;

    switch(ExtractTransport(ComPortNum))
    {
        case USART_TRANSPORT:
            ret = USART_Read( ConvertCOM_ComPort( ComPortNum ), Data, size );
            break;
        case USB_TRANSPORT:
            ret = USB_Read( ConvertCOM_UsbStream( ComPortNum ), Data, size );
            break;
        case SOCKET_TRANSPORT:
            ret = SOCKETS_Read( ConvertCOM_SockPort(ComPortNum), Data, size );
            break;
    }

    return ret;
}


BOOL DebuggerPort_Flush( COM_HANDLE ComPortNum )
{
    NATIVE_PROFILE_PAL_COM();
    switch(ExtractTransport(ComPortNum))
    {
        case USART_TRANSPORT:
            return USART_Flush( ConvertCOM_ComPort( ComPortNum ) );
        case USB_TRANSPORT:
            return USB_Flush( ConvertCOM_UsbStream(ComPortNum) );
        case SOCKET_TRANSPORT:
            return SOCKETS_Flush( ConvertCOM_SockPort(ComPortNum) );
    }

    return FALSE;
}

BOOL DebuggerPort_IsSslSupported( COM_HANDLE ComPortNum )
{
    NATIVE_PROFILE_PAL_COM();
    switch(ExtractTransport(ComPortNum))
    {
        case SOCKET_TRANSPORT:
            return g_DebuggerPortSslConfig.GetCertificateAuthority != NULL;

        case USART_TRANSPORT:
        case USB_TRANSPORT:
        default:
            break;
    }

    return FALSE;
}

BOOL DebuggerPort_UpgradeToSsl( COM_HANDLE ComPortNum, UINT32 flags )
{
    switch(ExtractTransport(ComPortNum))
    {
        case SOCKET_TRANSPORT:
            {
                LPCSTR szTargetHost  = NULL;
                UINT8* pCACert       = NULL;
                UINT32 caCertLen     = 0;
                UINT8* pDeviceCert   = NULL;
                UINT32 deviceCertLen = 0;

                if(g_DebuggerPortSslConfig.GetCertificateAuthority != NULL)
                {
                    g_DebuggerPortSslConfig.GetCertificateAuthority(&pCACert, &caCertLen);
                }

                if(g_DebuggerPortSslConfig.GetTargetHostName != NULL)
                {
                    g_DebuggerPortSslConfig.GetTargetHostName(&szTargetHost);
                }

                if(g_DebuggerPortSslConfig.GetDeviceCertificate != NULL)
                {
                    g_DebuggerPortSslConfig.GetDeviceCertificate(&pDeviceCert, &deviceCertLen);
                }
                
                return SOCKETS_UpgradeToSsl(ConvertCOM_ComPort(ComPortNum), pCACert, caCertLen, pDeviceCert, deviceCertLen, szTargetHost);
            }
    }

    return FALSE;
}

BOOL DebuggerPort_IsUsingSsl( COM_HANDLE ComPortNum )
{
        switch(ExtractTransport(ComPortNum))
        {
            case SOCKET_TRANSPORT:
                return SOCKETS_IsUsingSsl(ConvertCOM_ComPort(ComPortNum));
        }
        return FALSE;
}


//////////////////////////////////////////////////////////////////////////////////

void CPU_InitializeCommunication()
{
    NATIVE_PROFILE_PAL_COM();
    // STDIO can be different from the Debug Text port
    // do these first so we can print out messages

    if(COM_IsSerial(HalSystemConfig.DebugTextPort))
    {
        USART_Initialize( ConvertCOM_ComPort(HalSystemConfig.DebugTextPort), HalSystemConfig.USART_DefaultBaudRate, USART_PARITY_NONE, 8, USART_STOP_BITS_ONE, USART_FLOW_NONE );
    }

    if(COM_IsSerial(HalSystemConfig.stdio))
    {
        USART_Initialize( ConvertCOM_ComPort(HalSystemConfig.stdio), HalSystemConfig.USART_DefaultBaudRate, USART_PARITY_NONE, 8, USART_STOP_BITS_ONE, USART_FLOW_NONE );
    }

    if(COM_IsUsb(HalSystemConfig.DebugTextPort))
    {
        if(USB_CONFIG_ERR_OK == USB_Configure( ConvertCOM_UsbController(HalSystemConfig.DebugTextPort), NULL ))
        {
            USB_Initialize( ConvertCOM_UsbController(HalSystemConfig.DebugTextPort) );
            USB_OpenStream( ConvertCOM_UsbStream(HalSystemConfig.DebugTextPort), USB_DEBUG_EP_WRITE, USB_DEBUG_EP_READ );
        }
    }


    Network_Initialize();
}

void CPU_UninitializeCommunication()
{
    NATIVE_PROFILE_PAL_COM();
    // STDIO can be different from the Debug Text port
    // do these first so we can print out messages

    if(COM_IsSerial(HalSystemConfig.DebugTextPort))
    {
        USART_Uninitialize( ConvertCOM_ComPort(HalSystemConfig.DebugTextPort) );
    }
    if(COM_IsSerial(HalSystemConfig.stdio))
    {
        USART_Uninitialize( ConvertCOM_ComPort(HalSystemConfig.stdio) );
    }

    // if USB is not defined, the STUB_USB will be set
    // Do not uninitialize the USB on soft reboot if USB is our debugger link
    // Close all streams on USB controller 0 except debugger (if it uses a USB stream)
    for( int stream = 0; stream < USB_MAX_QUEUES; stream++ )
    {
        // discard output data
        USB_DiscardData(stream, TRUE);
        
        if(!COM_IsUsb(HalSystemConfig.DebuggerPorts[0]) || (ConvertCOM_UsbStream(HalSystemConfig.DebuggerPorts[0]) != stream))
        {
            USB_CloseStream(stream);        // OK for unopen streams
        }
    }
    USB_Uninitialize(0);        // USB_Uninitialize will only stop USB controller 0 if it has no open streams
    
    Network_Uninitialize();
}


void CPU_ProtectCommunicationGPIOs( BOOL On )
{
    NATIVE_PROFILE_PAL_COM();

    switch(ExtractTransport(HalSystemConfig.DebugTextPort))
    {
        case USART_TRANSPORT:
            CPU_USART_ProtectPins( ConvertCOM_ComPort(HalSystemConfig.DebugTextPort), On );
            return ;
        case USB_TRANSPORT:
            CPU_USB_ProtectPins  ( ConvertCOM_UsbController(HalSystemConfig.DebugTextPort), On );
            return;
        default:
            return;
    }
}
