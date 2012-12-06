////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Microsoft Corporation.  All rights reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#include <cores\arm\include\cpu.h>
#include "AT91_USB.h"

USB_CONTROLLER_STATE * CPU_USB_GetState( int Controller )
{
    return AT91_USB_Driver::GetState( Controller );
}

HRESULT CPU_USB_Initialize( int Controller )
{
    return AT91_USB_Driver::Initialize( Controller );
}

HRESULT CPU_USB_Uninitialize( int Controller )
{
    return AT91_USB_Driver::Uninitialize( Controller );
}

BOOL CPU_USB_StartOutput( USB_CONTROLLER_STATE* State, int endpoint )
{
    return AT91_USB_Driver::StartOutput( State, endpoint );
}

BOOL CPU_USB_RxEnable( USB_CONTROLLER_STATE* State, int endpoint )
{
    return AT91_USB_Driver::RxEnable( State, endpoint );
}

BOOL CPU_USB_GetInterruptState()
{
    return AT91_USB_Driver::GetInterruptState();
}

BOOL CPU_USB_ProtectPins( int Controller, BOOL On )
{
    return AT91_USB_Driver::ProtectPins( Controller, On );
}

