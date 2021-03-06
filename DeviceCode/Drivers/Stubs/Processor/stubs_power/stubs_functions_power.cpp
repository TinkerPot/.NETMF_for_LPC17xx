////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Microsoft Corporation.  All rights reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#include <tinyhal.h>

//--//

void HAL_AssertEx()
{
    // cause an abort and let the abort handler take over
    //*((char*)0xFFFFFFFF) = 'a';
}

//--//

BOOL CPU_Initialize()
{
    return TRUE;
}

void CPU_Reset()
{
}

void CPU_Sleep(SLEEP_LEVEL level, UINT64 wakeEvents)
{
}

void CPU_ChangePowerLevel(POWER_LEVEL level)
{
}

BOOL CPU_IsSoftRebootSupported ()
{
    return FALSE;
}


void CPU_Halt()
{
}


