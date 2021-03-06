////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Microsoft Corporation.  All rights reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////namespace System
namespace System
{

    using System;
    /**
     *  This value type is used for making Type.GetTypeFromHandle() type safe.
     *
     *  SECURITY : m_ptr cannot be set to anything other than null by untrusted
     *  code.
     *
     *  This corresponds to EE TypeHandle.
     */
    [Serializable()]
    public struct RuntimeTypeHandle
    {
    }
}


