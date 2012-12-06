////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Microsoft Corporation.  All rights reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////#include <tinyhal.h>
#include <tinyhal.h>
#include "SH7619_EDMAC_Adapter.h"

SH7619_EDMAC_Driver g_SH7619_EDMAC_Driver;


// extern SH7619_EDMAC_DRIVER_CONFIG g_SH7619_EDMAC_Config;

extern void SH7619_EDMAC_interrupt(void *param);
// -- //

BOOL Network_Interface_Bind(int index)
{
    return SH7619_EDMAC_Driver::Bind();
}
int  Network_Interface_Open(int index)
{
    return SH7619_EDMAC_Driver::Open();
}
BOOL Network_Interface_Close(int index)
{
    return SH7619_EDMAC_Driver::Close();
}

int SH7619_EDMAC_Driver::Open()
{
    int use_default_multicast;

    memset(&g_SH7619_EDMAC_Driver.m_currentDhcpSession, 0, sizeof(g_SH7619_EDMAC_Driver.m_currentDhcpSession));

    // PHY Power Up
    // CPU_GPIO_EnableOutputPin(g_SH7619_EDMAC_Config.PHY_PD_GPIO_Pin, FALSE);

     /* Open the interface first */
    g_SH7619_EDMAC_Driver.m_interfaceNumber = xn_interface_open_config(SH7619_EDMAC_DEVICE, 
                                                    0,              /*  minor_number        */
                                                    0,              /*  ioaddress           */
                                                    0,              /*  irq value           */
                                                    0               /*  mem_address)        */
                                                    );

    if (g_SH7619_EDMAC_Driver.m_interfaceNumber == -1)
    {
        return -1;    
    }
    
    use_default_multicast = 1;
    if (xn_interface_opt(g_SH7619_EDMAC_Driver.m_interfaceNumber, 
                        IO_DEFAULT_MCAST,
                        (RTP_PFCCHAR)&use_default_multicast,
                        sizeof(int)) == -1)
    {
        /* Failed to set the default multicast interface */
        hal_printf("EDMAC: Failed to set the default multicast interface\r\n");
    }

    //CPU_INTC_ActivateInterrupt(SH7619C_ID_EDMAC, SH7619_EDMAC_interrupt, NULL);
	//CPU_INTC_ActivateInterrupt(81, SH7619_EDMAC_interrupt, NULL);
	
    return g_SH7619_EDMAC_Driver.m_interfaceNumber;
}

// -- //

BOOL SH7619_EDMAC_Driver::Close(void)
{
    int retVal = -1;

    //CPU_INTC_DeactivateInterrupt(SH7619C_ID_EDMAC);
	CPU_INTC_DeactivateInterrupt(81);

    /* JRT - changed interface number from 0 */
    retVal = xn_interface_close(g_SH7619_EDMAC_Driver.m_interfaceNumber);
    
    
    if (retVal == 0)
    {
        /* JRT - Wait not necessary since just did a HARD_CLOSE above
        xn_wait_pkts_output(RTP_TRUE, 60);
        */
        return TRUE;
    }
    else
    {
        return FALSE;
    }
}

BOOL SH7619_EDMAC_Driver::Bind(void)
{
    int retVal;
    
    retVal = xn_bind_sh7619_mac(0);

    if (retVal != -1)
    {
        return TRUE;
    }
    else
    {
        return FALSE;
    }
}

