////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Microsoft Corporation.  All rights reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Reflection;
using Microsoft.SPOT.Platform.Test;

namespace Microsoft.SPOT.Platform.Tests
{
    public class Expenum2Tests : IMFTestInterface
    {
        [SetUp]
        public InitializeResult Initialize()
        {
            Log.Comment("Adding set up for the tests.");
            // Add your functionality here.   
            
            return InitializeResult.ReadyToGo;
        }
        
        [TearDown]
        public void CleanUp()
        {
            Log.Comment("Cleaning up after the tests");
        }

        //Expenum Test methods
        //The following tests were ported from folder current\test\cases\client\CLR\Conformance\10_classes\Expenum
        //byte_to_byte_enum_rtime_s,byte_to_int_enum_rtime_s,byte_to_long_enum_rtime_s,byte_to_sbyte_enum_rtime_s,
        //byte_to_short_enum_rtime_s,byte_to_uint_enum_rtime_s,byte_to_ulong_enum_rtime_s,byte_to_ushort_enum_rtime_s,
        //double_to_byte_enum_rtime_s,double_to_int_enum_rtime_s,double_to_long_enum_rtime_s,double_to_sbyte_enum_rtime_s,
        //double_to_short_enum_rtime_s,double_to_uint_enum_rtime_s,double_to_ulong_enum_rtime_s,
        //double_to_ushort_enum_rtime_s,float_to_byte_enum_rtime_s,float_to_int_enum_rtime_s,float_to_long_enum_rtime_s,
        //float_to_sbyte_enum_rtime_s,float_to_short_enum_rtime_s,float_to_uint_enum_rtime_s,float_to_ulong_enum_rtime_s,
        //float_to_ushort_enum_rtime_s,short_enum_to_float_rtime_s,short_enum_to_int_rtime_s,int_to_byte_enum_rtime_s,
        //int_to_int_enum_rtime_s,int_to_long_enum_rtime_s,int_to_sbyte_enum_rtime_s,int_to_short_enum_rtime_s,
        //int_to_uint_enum_rtime_s,int_to_ulong_enum_rtime_s,int_to_ushort_enum_rtime_s,long_to_byte_enum_rtime_s,
        //long_to_int_enum_rtime_s,long_to_long_enum_rtime_s,long_to_sbyte_enum_rtime_s,long_to_short_enum_rtime_s,
        //long_to_uint_enum_rtime_s,long_to_ulong_enum_rtime_s,long_to_ushort_enum_rtime_s,sbyte_to_byte_enum_rtime_s,
        //sbyte_to_int_enum_rtime_s,sbyte_to_long_enum_rtime_s,sbyte_to_sbyte_enum_rtime_s,sbyte_to_short_enum_rtime_s,
        //sbyte_to_uint_enum_rtime_s,sbyte_to_ulong_enum_rtime_s,sbyte_to_ushort_enum_rtime_s,short_to_byte_enum_rtime_s,
        //short_to_int_enum_rtime_s,short_to_long_enum_rtime_s,short_to_sbyte_enum_rtime_s,short_to_short_enum_rtime_s,
        //short_to_uint_enum_rtime_s,short_to_ulong_enum_rtime_s,short_to_ushort_enum_rtime_s,uint_to_byte_enum_rtime_s,
        //uint_to_int_enum_rtime_s,uint_to_long_enum_rtime_s,uint_to_sbyte_enum_rtime_s,uint_to_short_enum_rtime_s,
        //uint_to_uint_enum_rtime_s,uint_to_ulong_enum_rtime_s,uint_to_ushort_enum_rtime_s,ulong_to_byte_enum_rtime_s,
        //ulong_to_int_enum_rtime_s,ulong_to_long_enum_rtime_s,ulong_to_sbyte_enum_rtime_s,ulong_to_short_enum_rtime_s,
        //ulong_to_uint_enum_rtime_s,ulong_to_ulong_enum_rtime_s,ulong_to_ushort_enum_rtime_s,ushort_to_byte_enum_rtime_s,
        //ushort_to_int_enum_rtime_s,ushort_to_long_enum_rtime_s,ushort_to_sbyte_enum_rtime_s,ushort_to_short_enum_rtime_s,
        //ushort_to_uint_enum_rtime_s,ushort_to_ulong_enum_rtime_s,ushort_to_ushort_enum_rtime_s,int_enum_to_ushort_rtime_s,
        //long_enum_to_byte_rtime_s,long_enum_to_double_rtime_s,long_enum_to_float_rtime_s,long_enum_to_int_rtime_s,
        //long_enum_to_long_rtime_s,long_enum_to_sbyte_rtime_s,long_enum_to_short_rtime_s,long_enum_to_uint_rtime_s,
        //long_enum_to_ulong_rtime_s,long_enum_to_ushort_rtime_s,sbyte_enum_to_byte_rtime_s,sbyte_enum_to_double_rtime_s,
        //sbyte_enum_to_float_rtime_s,sbyte_enum_to_int_rtime_s,sbyte_enum_to_long_rtime_s,sbyte_enum_to_sbyte_rtime_s,
        //sbyte_enum_to_short_rtime_s,sbyte_enum_to_uint_rtime_s,sbyte_enum_to_ulong_rtime_s,sbyte_enum_to_ushort_rtime_s,
        //short_enum_to_byte_rtime_s,short_enum_to_double_rtime_s,short_enum_to_long_rtime_s,short_enum_to_sbyte_rtime_s,
        //short_enum_to_short_rtime_s,short_enum_to_uint_rtime_s,short_enum_to_ulong_rtime_s,short_enum_to_ushort_rtime_s,
        //uint_enum_to_byte_rtime_s,uint_enum_to_double_rtime_s,uint_enum_to_float_rtime_s,uint_enum_to_int_rtime_s,
        //uint_enum_to_long_rtime_s,uint_enum_to_sbyte_rtime_s,uint_enum_to_short_rtime_s,uint_enum_to_uint_rtime_s,
        //uint_enum_to_ulong_rtime_s,uint_enum_to_ushort_rtime_s,ulong_enum_to_byte_rtime_s,ulong_enum_to_double_rtime_s,
        //ulong_enum_to_float_rtime_s,ulong_enum_to_int_rtime_s,ulong_enum_to_long_rtime_s,ulong_enum_to_sbyte_rtime_s,
        //ulong_enum_to_short_rtime_s,ulong_enum_to_uint_rtime_s,ulong_enum_to_ulong_rtime_s,ulong_enum_to_ushort_rtime_s,
        //ushort_enum_to_byte_rtime_s,ushort_enum_to_double_rtime_s,ushort_enum_to_float_rtime_s,ushort_enum_to_int_rtime_s,
        //ushort_enum_to_long_rtime_s,ushort_enum_to_sbyte_rtime_s,ushort_enum_to_short_rtime_s,ushort_enum_to_uint_rtime_s,
        //ushort_enum_to_ulong_rtime_s,ushort_enum_to_ushort_rtime_s,byte_enum_to_byte_rtime_s,byte_enum_to_double_rtime_s,
        //byte_enum_to_float_rtime_s,byte_enum_to_int_rtime_s,byte_enum_to_long_rtime_s,byte_enum_to_sbyte_rtime_s,
        //byte_enum_to_short_rtime_s,byte_enum_to_uint_rtime_s,byte_enum_to_ulong_rtime_s,byte_enum_to_ushort_rtime_s,
        //int_enum_to_byte_rtime_s,int_enum_to_double_rtime_s,int_enum_to_float_rtime_s,int_enum_to_int_rtime_s,
        //int_enum_to_long_rtime_s,int_enum_to_sbyte_rtime_s,int_enum_to_short_rtime_s,int_enum_to_uint_rtime_s,
        //int_enum_to_ulong_rtime_s,int_enum_to_ulong_enum_rtime_s,int_enum_to_ushort_enum_rtime_s,long_enum_to_byte_enum_rtime_s,
        //long_enum_to_int_enum_rtime_s,long_enum_to_long_enum_rtime_s,long_enum_to_sbyte_enum_rtime_s,long_enum_to_short_enum_rtime_s,
        //long_enum_to_uint_enum_rtime_s,long_enum_to_ulong_enum_rtime_s,long_enum_to_ushort_enum_rtime_s,
        //sbyte_enum_to_byte_enum_rtime_s,sbyte_enum_to_int_enum_rtime_s,sbyte_enum_to_long_enum_rtime_s,sbyte_enum_to_sbyte_enum_rtime_s,
        //sbyte_enum_to_short_enum_rtime_s,sbyte_enum_to_uint_enum_rtime_s,sbyte_enum_to_ulong_enum_rtime_s,sbyte_enum_to_ushort_enum_rtime_s,
        //short_enum_to_byte_enum_rtime_s,short_enum_to_int_enum_rtime_s,short_enum_to_long_enum_rtime_s,short_enum_to_sbyte_enum_rtime_s,
        //short_enum_to_short_enum_rtime_s,short_enum_to_uint_enum_rtime_s,short_enum_to_ulong_enum_rtime_s,short_enum_to_ushort_enum_rtime_s,
        //uint_enum_to_byte_enum_rtime_s,uint_enum_to_int_enum_rtime_s,uint_enum_to_long_enum_rtime_s,uint_enum_to_sbyte_enum_rtime_s,
        //uint_enum_to_short_enum_rtime_s,uint_enum_to_uint_enum_rtime_s,uint_enum_to_ulong_enum_rtime_s,uint_enum_to_ushort_enum_rtime_s,
        //ulong_enum_to_byte_enum_rtime_s,ulong_enum_to_int_enum_rtime_s,ulong_enum_to_long_enum_rtime_s,ulong_enum_to_sbyte_enum_rtime_s,
        //ulong_enum_to_short_enum_rtime_s,ulong_enum_to_uint_enum_rtime_s,ulong_enum_to_ulong_enum_rtime_s,ulong_enum_to_ushort_enum_rtime_s,
        //ushort_enum_to_byte_enum_rtime_s,ushort_enum_to_int_enum_rtime_s,ushort_enum_to_long_enum_rtime_s,ushort_enum_to_sbyte_enum_rtime_s,
        //ushort_enum_to_short_enum_rtime_s,ushort_enum_to_uint_enum_rtime_s,ushort_enum_to_ulong_enum_rtime_s,ushort_enum_to_ushort_enum_rtime_s,
        //byte_enum_to_byte_enum_rtime_s,byte_enum_to_int_enum_rtime_s,byte_enum_to_long_enum_rtime_s,byte_enum_to_sbyte_enum_rtime_s,
        //byte_enum_to_short_enum_rtime_s,byte_enum_to_uint_enum_rtime_s,byte_enum_to_ulong_enum_rtime_s,byte_enum_to_ushort_enum_rtime_s,
        //int_enum_to_byte_enum_rtime_s,int_enum_to_int_enum_rtime_s,int_enum_to_long_enum_rtime_s,int_enum_to_sbyte_enum_rtime_s
        //int_enum_to_short_enum_rtime_s,int_enum_to_uint_enum_rtime_s

        //Test Case Calls 

        
        [TestMethod]
        public MFTestResults Expenum_sbyte_enum_to_int_rtime_s_Test()
        {
            if (ExpenumTestClass_sbyte_enum_to_int_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_sbyte_enum_to_long_rtime_s_Test()
        {
            if (ExpenumTestClass_sbyte_enum_to_long_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_sbyte_enum_to_sbyte_rtime_s_Test()
        {
            if (ExpenumTestClass_sbyte_enum_to_sbyte_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_sbyte_enum_to_short_rtime_s_Test()
        {
            if (ExpenumTestClass_sbyte_enum_to_short_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_sbyte_enum_to_uint_rtime_s_Test()
        {
            if (ExpenumTestClass_sbyte_enum_to_uint_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_sbyte_enum_to_ulong_rtime_s_Test()
        {
            if (ExpenumTestClass_sbyte_enum_to_ulong_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_sbyte_enum_to_ushort_rtime_s_Test()
        {
            if (ExpenumTestClass_sbyte_enum_to_ushort_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_short_enum_to_byte_rtime_s_Test()
        {
            if (ExpenumTestClass_short_enum_to_byte_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_short_enum_to_double_rtime_s_Test()
        {
            if (ExpenumTestClass_short_enum_to_double_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_short_enum_to_long_rtime_s_Test()
        {
            if (ExpenumTestClass_short_enum_to_long_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_short_enum_to_sbyte_rtime_s_Test()
        {
            if (ExpenumTestClass_short_enum_to_sbyte_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_short_enum_to_short_rtime_s_Test()
        {
            if (ExpenumTestClass_short_enum_to_short_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_short_enum_to_uint_rtime_s_Test()
        {
            if (ExpenumTestClass_short_enum_to_uint_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_short_enum_to_ulong_rtime_s_Test()
        {
            if (ExpenumTestClass_short_enum_to_ulong_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_short_enum_to_ushort_rtime_s_Test()
        {
            if (ExpenumTestClass_short_enum_to_ushort_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_uint_enum_to_byte_rtime_s_Test()
        {
            if (ExpenumTestClass_uint_enum_to_byte_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_uint_enum_to_double_rtime_s_Test()
        {
            if (ExpenumTestClass_uint_enum_to_double_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_uint_enum_to_float_rtime_s_Test()
        {
            if (ExpenumTestClass_uint_enum_to_float_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_uint_enum_to_int_rtime_s_Test()
        {
            if (ExpenumTestClass_uint_enum_to_int_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_uint_enum_to_long_rtime_s_Test()
        {
            if (ExpenumTestClass_uint_enum_to_long_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_uint_enum_to_sbyte_rtime_s_Test()
        {
            if (ExpenumTestClass_uint_enum_to_sbyte_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_uint_enum_to_short_rtime_s_Test()
        {
            if (ExpenumTestClass_uint_enum_to_short_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_uint_enum_to_uint_rtime_s_Test()
        {
            if (ExpenumTestClass_uint_enum_to_uint_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        
        [TestMethod]
        public MFTestResults Expenum_uint_enum_to_ulong_rtime_s_Test()
        {
            if (ExpenumTestClass_uint_enum_to_ulong_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_uint_enum_to_ushort_rtime_s_Test()
        {
            if (ExpenumTestClass_uint_enum_to_ushort_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_ulong_enum_to_byte_rtime_s_Test()
        {
            if (ExpenumTestClass_ulong_enum_to_byte_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_ulong_enum_to_double_rtime_s_Test()
        {
            if (ExpenumTestClass_ulong_enum_to_double_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_ulong_enum_to_float_rtime_s_Test()
        {
            if (ExpenumTestClass_ulong_enum_to_float_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_ulong_enum_to_int_rtime_s_Test()
        {
            if (ExpenumTestClass_ulong_enum_to_int_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_ulong_enum_to_long_rtime_s_Test()
        {
            if (ExpenumTestClass_ulong_enum_to_long_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_ulong_enum_to_sbyte_rtime_s_Test()
        {
            if (ExpenumTestClass_ulong_enum_to_sbyte_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_ulong_enum_to_short_rtime_s_Test()
        {
            if (ExpenumTestClass_ulong_enum_to_short_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_ulong_enum_to_uint_rtime_s_Test()
        {
            if (ExpenumTestClass_ulong_enum_to_uint_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_ulong_enum_to_ulong_rtime_s_Test()
        {
            if (ExpenumTestClass_ulong_enum_to_ulong_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_ulong_enum_to_ushort_rtime_s_Test()
        {
            if (ExpenumTestClass_ulong_enum_to_ushort_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_ushort_enum_to_byte_rtime_s_Test()
        {
            if (ExpenumTestClass_ushort_enum_to_byte_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_ushort_enum_to_double_rtime_s_Test()
        {
            if (ExpenumTestClass_ushort_enum_to_double_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_ushort_enum_to_float_rtime_s_Test()
        {
            if (ExpenumTestClass_ushort_enum_to_float_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_ushort_enum_to_int_rtime_s_Test()
        {
            if (ExpenumTestClass_ushort_enum_to_int_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_ushort_enum_to_long_rtime_s_Test()
        {
            if (ExpenumTestClass_ushort_enum_to_long_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_ushort_enum_to_sbyte_rtime_s_Test()
        {
            if (ExpenumTestClass_ushort_enum_to_sbyte_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_ushort_enum_to_short_rtime_s_Test()
        {
            if (ExpenumTestClass_ushort_enum_to_short_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_ushort_enum_to_uint_rtime_s_Test()
        {
            if (ExpenumTestClass_ushort_enum_to_uint_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_ushort_enum_to_ulong_rtime_s_Test()
        {
            if (ExpenumTestClass_ushort_enum_to_ulong_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_ushort_enum_to_ushort_rtime_s_Test()
        {
            if (ExpenumTestClass_ushort_enum_to_ushort_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_byte_enum_to_byte_rtime_s_Test()
        {
            if (ExpenumTestClass_byte_enum_to_byte_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_byte_enum_to_double_rtime_s_Test()
        {
            if (ExpenumTestClass_byte_enum_to_double_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_byte_enum_to_float_rtime_s_Test()
        {
            if (ExpenumTestClass_byte_enum_to_float_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_byte_enum_to_int_rtime_s_Test()
        {
            if (ExpenumTestClass_byte_enum_to_int_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_byte_enum_to_long_rtime_s_Test()
        {
            if (ExpenumTestClass_byte_enum_to_long_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_byte_enum_to_sbyte_rtime_s_Test()
        {
            if (ExpenumTestClass_byte_enum_to_sbyte_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_byte_enum_to_short_rtime_s_Test()
        {
            if (ExpenumTestClass_byte_enum_to_short_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_byte_enum_to_uint_rtime_s_Test()
        {
            if (ExpenumTestClass_byte_enum_to_uint_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_byte_enum_to_ulong_rtime_s_Test()
        {
            if (ExpenumTestClass_byte_enum_to_ulong_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_byte_enum_to_ushort_rtime_s_Test()
        {
            if (ExpenumTestClass_byte_enum_to_ushort_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_int_enum_to_byte_rtime_s_Test()
        {
            if (ExpenumTestClass_int_enum_to_byte_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_int_enum_to_double_rtime_s_Test()
        {
            if (ExpenumTestClass_int_enum_to_double_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_int_enum_to_float_rtime_s_Test()
        {
            if (ExpenumTestClass_int_enum_to_float_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_int_enum_to_int_rtime_s_Test()
        {
            if (ExpenumTestClass_int_enum_to_int_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_int_enum_to_long_rtime_s_Test()
        {
            if (ExpenumTestClass_int_enum_to_long_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_int_enum_to_sbyte_rtime_s_Test()
        {
            if (ExpenumTestClass_int_enum_to_sbyte_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_int_enum_to_short_rtime_s_Test()
        {
            if (ExpenumTestClass_int_enum_to_short_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_int_enum_to_uint_rtime_s_Test()
        {
            if (ExpenumTestClass_int_enum_to_uint_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_int_enum_to_ulong_rtime_s_Test()
        {
            if (ExpenumTestClass_int_enum_to_ulong_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_int_enum_to_ulong_enum_rtime_s_Test()
        {
            if (ExpenumTestClass_int_enum_to_ulong_enum_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_int_enum_to_ushort_enum_rtime_s_Test()
        {
            if (ExpenumTestClass_int_enum_to_ushort_enum_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_long_enum_to_byte_enum_rtime_s_Test()
        {
            if (ExpenumTestClass_long_enum_to_byte_enum_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_long_enum_to_int_enum_rtime_s_Test()
        {
            if (ExpenumTestClass_long_enum_to_int_enum_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_long_enum_to_long_enum_rtime_s_Test()
        {
            if (ExpenumTestClass_long_enum_to_long_enum_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_long_enum_to_sbyte_enum_rtime_s_Test()
        {
            if (ExpenumTestClass_long_enum_to_sbyte_enum_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        
        [TestMethod]
        public MFTestResults Expenum_long_enum_to_short_enum_rtime_s_Test()
        {
            if (ExpenumTestClass_long_enum_to_short_enum_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_long_enum_to_uint_enum_rtime_s_Test()
        {
            if (ExpenumTestClass_long_enum_to_uint_enum_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_long_enum_to_ulong_enum_rtime_s_Test()
        {
            if (ExpenumTestClass_long_enum_to_ulong_enum_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_long_enum_to_ushort_enum_rtime_s_Test()
        {
            if (ExpenumTestClass_long_enum_to_ushort_enum_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_sbyte_enum_to_byte_enum_rtime_s_Test()
        {
            if (ExpenumTestClass_sbyte_enum_to_byte_enum_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        
        [TestMethod]
        public MFTestResults Expenum_sbyte_enum_to_int_enum_rtime_s_Test()
        {
            if (ExpenumTestClass_sbyte_enum_to_int_enum_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_sbyte_enum_to_long_enum_rtime_s_Test()
        {
            if (ExpenumTestClass_sbyte_enum_to_long_enum_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_sbyte_enum_to_sbyte_enum_rtime_s_Test()
        {
            if (ExpenumTestClass_sbyte_enum_to_sbyte_enum_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_sbyte_enum_to_short_enum_rtime_s_Test()
        {
            if (ExpenumTestClass_sbyte_enum_to_short_enum_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_sbyte_enum_to_uint_enum_rtime_s_Test()
        {
            if (ExpenumTestClass_sbyte_enum_to_uint_enum_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        
        [TestMethod]
        public MFTestResults Expenum_byte_enum_to_ulong_enum_rtime_s_Test()
        {
            if (ExpenumTestClass_byte_enum_to_ulong_enum_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_byte_enum_to_ushort_enum_rtime_s_Test()
        {
            if (ExpenumTestClass_byte_enum_to_ushort_enum_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_int_enum_to_byte_enum_rtime_s_Test()
        {
            if (ExpenumTestClass_int_enum_to_byte_enum_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_int_enum_to_int_enum_rtime_s_Test()
        {
            if (ExpenumTestClass_int_enum_to_int_enum_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_int_enum_to_long_enum_rtime_s_Test()
        {
            if (ExpenumTestClass_int_enum_to_long_enum_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_int_enum_to_sbyte_enum_rtime_s_Test()
        {
            if (ExpenumTestClass_int_enum_to_sbyte_enum_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_int_enum_to_short_enum_rtime_s_Test()
        {
            if (ExpenumTestClass_int_enum_to_short_enum_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Expenum_int_enum_to_uint_enum_rtime_s_Test()
        {
            if (ExpenumTestClass_int_enum_to_uint_enum_rtime_s.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        

        enum ExpenumTestClass_sbyte_enum_to_int_rtime_s_SrcEnumType : sbyte { ValOne = 1 }
        public class ExpenumTestClass_sbyte_enum_to_int_rtime_s
        {
            public static bool testMethod()
            {
                int Destination;
                ExpenumTestClass_sbyte_enum_to_int_rtime_s_SrcEnumType Source = ExpenumTestClass_sbyte_enum_to_int_rtime_s_SrcEnumType.ValOne;
                Destination = (int)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_sbyte_enum_to_long_rtime_s_SrcEnumType : sbyte { ValOne = 1 }
        public class ExpenumTestClass_sbyte_enum_to_long_rtime_s
        {
            public static bool testMethod()
            {
                long Destination;
                ExpenumTestClass_sbyte_enum_to_long_rtime_s_SrcEnumType Source = ExpenumTestClass_sbyte_enum_to_long_rtime_s_SrcEnumType.ValOne;
                Destination = (long)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_sbyte_enum_to_sbyte_rtime_s_SrcEnumType : sbyte { ValOne = 1 }
        public class ExpenumTestClass_sbyte_enum_to_sbyte_rtime_s
        {
            public static bool testMethod()
            {
                sbyte Destination;
                ExpenumTestClass_sbyte_enum_to_sbyte_rtime_s_SrcEnumType Source = ExpenumTestClass_sbyte_enum_to_sbyte_rtime_s_SrcEnumType.ValOne;
                Destination = (sbyte)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_sbyte_enum_to_short_rtime_s_SrcEnumType : sbyte { ValOne = 1 }
        public class ExpenumTestClass_sbyte_enum_to_short_rtime_s
        {
            public static bool testMethod()
            {
                short Destination;
                ExpenumTestClass_sbyte_enum_to_short_rtime_s_SrcEnumType Source = ExpenumTestClass_sbyte_enum_to_short_rtime_s_SrcEnumType.ValOne;
                Destination = (short)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_sbyte_enum_to_uint_rtime_s_SrcEnumType : sbyte { ValOne = 1 }
        public class ExpenumTestClass_sbyte_enum_to_uint_rtime_s
        {
            public static bool testMethod()
            {
                uint Destination;
                ExpenumTestClass_sbyte_enum_to_uint_rtime_s_SrcEnumType Source = ExpenumTestClass_sbyte_enum_to_uint_rtime_s_SrcEnumType.ValOne;
                Destination = (uint)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_sbyte_enum_to_ulong_rtime_s_SrcEnumType : sbyte { ValOne = 1 }
        public class ExpenumTestClass_sbyte_enum_to_ulong_rtime_s
        {
            public static bool testMethod()
            {
                ulong Destination;
                ExpenumTestClass_sbyte_enum_to_ulong_rtime_s_SrcEnumType Source = ExpenumTestClass_sbyte_enum_to_ulong_rtime_s_SrcEnumType.ValOne;
                Destination = (ulong)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_sbyte_enum_to_ushort_rtime_s_SrcEnumType : sbyte { ValOne = 1 }
        public class ExpenumTestClass_sbyte_enum_to_ushort_rtime_s
        {
            public static bool testMethod()
            {
                ushort Destination;
                ExpenumTestClass_sbyte_enum_to_ushort_rtime_s_SrcEnumType Source = ExpenumTestClass_sbyte_enum_to_ushort_rtime_s_SrcEnumType.ValOne;
                Destination = (ushort)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_short_enum_to_byte_rtime_s_SrcEnumType : short { ValOne = 1 }
        public class ExpenumTestClass_short_enum_to_byte_rtime_s
        {
            public static bool testMethod()
            {
                byte Destination;
                ExpenumTestClass_short_enum_to_byte_rtime_s_SrcEnumType Source = ExpenumTestClass_short_enum_to_byte_rtime_s_SrcEnumType.ValOne;
                Destination = (byte)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_short_enum_to_double_rtime_s_SrcEnumType : short { ValOne = 1 }
        public class ExpenumTestClass_short_enum_to_double_rtime_s
        {
            public static bool testMethod()
            {
                double Destination;
                ExpenumTestClass_short_enum_to_double_rtime_s_SrcEnumType Source = ExpenumTestClass_short_enum_to_double_rtime_s_SrcEnumType.ValOne;
                Destination = (double)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_short_enum_to_long_rtime_s_SrcEnumType : short { ValOne = 1 }
        public class ExpenumTestClass_short_enum_to_long_rtime_s
        {
            public static bool testMethod()
            {
                long Destination;
                ExpenumTestClass_short_enum_to_long_rtime_s_SrcEnumType Source = ExpenumTestClass_short_enum_to_long_rtime_s_SrcEnumType.ValOne;
                Destination = (long)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_short_enum_to_sbyte_rtime_s_SrcEnumType : short { ValOne = 1 }
        public class ExpenumTestClass_short_enum_to_sbyte_rtime_s
        {
            public static bool testMethod()
            {
                sbyte Destination;
                ExpenumTestClass_short_enum_to_sbyte_rtime_s_SrcEnumType Source = ExpenumTestClass_short_enum_to_sbyte_rtime_s_SrcEnumType.ValOne;
                Destination = (sbyte)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_short_enum_to_short_rtime_s_SrcEnumType : short { ValOne = 1 }
        public class ExpenumTestClass_short_enum_to_short_rtime_s
        {
            public static bool testMethod()
            {
                short Destination;
                ExpenumTestClass_short_enum_to_short_rtime_s_SrcEnumType Source = ExpenumTestClass_short_enum_to_short_rtime_s_SrcEnumType.ValOne;
                Destination = (short)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_short_enum_to_uint_rtime_s_SrcEnumType : short { ValOne = 1 }
        public class ExpenumTestClass_short_enum_to_uint_rtime_s
        {
            public static bool testMethod()
            {
                uint Destination;
                ExpenumTestClass_short_enum_to_uint_rtime_s_SrcEnumType Source = ExpenumTestClass_short_enum_to_uint_rtime_s_SrcEnumType.ValOne;
                Destination = (uint)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_short_enum_to_ulong_rtime_s_SrcEnumType : short { ValOne = 1 }
        public class ExpenumTestClass_short_enum_to_ulong_rtime_s
        {
            public static bool testMethod()
            {
                ulong Destination;
                ExpenumTestClass_short_enum_to_ulong_rtime_s_SrcEnumType Source = ExpenumTestClass_short_enum_to_ulong_rtime_s_SrcEnumType.ValOne;
                Destination = (ulong)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_short_enum_to_ushort_rtime_s_SrcEnumType : short { ValOne = 1 }
        public class ExpenumTestClass_short_enum_to_ushort_rtime_s
        {
            public static bool testMethod()
            {
                ushort Destination;
                ExpenumTestClass_short_enum_to_ushort_rtime_s_SrcEnumType Source = ExpenumTestClass_short_enum_to_ushort_rtime_s_SrcEnumType.ValOne;
                Destination = (ushort)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_uint_enum_to_byte_rtime_s_SrcEnumType : uint { ValOne = 1 }
        public class ExpenumTestClass_uint_enum_to_byte_rtime_s
        {
            public static bool testMethod()
            {
                byte Destination;
                ExpenumTestClass_uint_enum_to_byte_rtime_s_SrcEnumType Source = ExpenumTestClass_uint_enum_to_byte_rtime_s_SrcEnumType.ValOne;
                Destination = (byte)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_uint_enum_to_double_rtime_s_SrcEnumType : uint { ValOne = 1 }
        public class ExpenumTestClass_uint_enum_to_double_rtime_s
        {
            public static bool testMethod()
            {
                double Destination;
                ExpenumTestClass_uint_enum_to_double_rtime_s_SrcEnumType Source = ExpenumTestClass_uint_enum_to_double_rtime_s_SrcEnumType.ValOne;
                Destination = (double)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_uint_enum_to_float_rtime_s_SrcEnumType : uint { ValOne = 1 }
        public class ExpenumTestClass_uint_enum_to_float_rtime_s
        {
            public static bool testMethod()
            {
                float Destination;
                ExpenumTestClass_uint_enum_to_float_rtime_s_SrcEnumType Source = ExpenumTestClass_uint_enum_to_float_rtime_s_SrcEnumType.ValOne;
                Destination = (float)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_uint_enum_to_int_rtime_s_SrcEnumType : uint { ValOne = 1 }
        public class ExpenumTestClass_uint_enum_to_int_rtime_s
        {
            public static bool testMethod()
            {
                int Destination;
                ExpenumTestClass_uint_enum_to_int_rtime_s_SrcEnumType Source = ExpenumTestClass_uint_enum_to_int_rtime_s_SrcEnumType.ValOne;
                Destination = (int)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_uint_enum_to_long_rtime_s_SrcEnumType : uint { ValOne = 1 }
        public class ExpenumTestClass_uint_enum_to_long_rtime_s
        {
            public static bool testMethod()
            {
                long Destination;
                ExpenumTestClass_uint_enum_to_long_rtime_s_SrcEnumType Source = ExpenumTestClass_uint_enum_to_long_rtime_s_SrcEnumType.ValOne;
                Destination = (long)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_uint_enum_to_sbyte_rtime_s_SrcEnumType : uint { ValOne = 1 }
        public class ExpenumTestClass_uint_enum_to_sbyte_rtime_s
        {
            public static bool testMethod()
            {
                sbyte Destination;
                ExpenumTestClass_uint_enum_to_sbyte_rtime_s_SrcEnumType Source = ExpenumTestClass_uint_enum_to_sbyte_rtime_s_SrcEnumType.ValOne;
                Destination = (sbyte)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_uint_enum_to_short_rtime_s_SrcEnumType : uint { ValOne = 1 }
        public class ExpenumTestClass_uint_enum_to_short_rtime_s
        {
            public static bool testMethod()
            {
                short Destination;
                ExpenumTestClass_uint_enum_to_short_rtime_s_SrcEnumType Source = ExpenumTestClass_uint_enum_to_short_rtime_s_SrcEnumType.ValOne;
                Destination = (short)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        } 
        enum ExpenumTestClass_uint_enum_to_uint_rtime_s_SrcEnumType : uint { ValOne = 1 }
        public class ExpenumTestClass_uint_enum_to_uint_rtime_s
        {
            public static bool testMethod()
            {
                uint Destination;
                ExpenumTestClass_uint_enum_to_uint_rtime_s_SrcEnumType Source = ExpenumTestClass_uint_enum_to_uint_rtime_s_SrcEnumType.ValOne;
                Destination = (uint)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        
        enum ExpenumTestClass_uint_enum_to_ulong_rtime_s_SrcEnumType : uint { ValOne = 1 }
        public class ExpenumTestClass_uint_enum_to_ulong_rtime_s
        {
            public static bool testMethod()
            {
                ulong Destination;
                ExpenumTestClass_uint_enum_to_ulong_rtime_s_SrcEnumType Source = ExpenumTestClass_uint_enum_to_ulong_rtime_s_SrcEnumType.ValOne;
                Destination = (ulong)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_uint_enum_to_ushort_rtime_s_SrcEnumType : uint { ValOne = 1 }
        public class ExpenumTestClass_uint_enum_to_ushort_rtime_s
        {
            public static bool testMethod()
            {
                ushort Destination;
                ExpenumTestClass_uint_enum_to_ushort_rtime_s_SrcEnumType Source = ExpenumTestClass_uint_enum_to_ushort_rtime_s_SrcEnumType.ValOne;
                Destination = (ushort)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_ulong_enum_to_byte_rtime_s_SrcEnumType : ulong { ValOne = 1 }
        public class ExpenumTestClass_ulong_enum_to_byte_rtime_s
        {
            public static bool testMethod()
            {
                byte Destination;
                ExpenumTestClass_ulong_enum_to_byte_rtime_s_SrcEnumType Source = ExpenumTestClass_ulong_enum_to_byte_rtime_s_SrcEnumType.ValOne;
                Destination = (byte)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_ulong_enum_to_double_rtime_s_SrcEnumType : ulong { ValOne = 1 }
        public class ExpenumTestClass_ulong_enum_to_double_rtime_s
        {
            public static bool testMethod()
            {
                double Destination;
                ExpenumTestClass_ulong_enum_to_double_rtime_s_SrcEnumType Source = ExpenumTestClass_ulong_enum_to_double_rtime_s_SrcEnumType.ValOne;
                Destination = (double)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_ulong_enum_to_float_rtime_s_SrcEnumType : ulong { ValOne = 1 }
        public class ExpenumTestClass_ulong_enum_to_float_rtime_s
        {
            public static bool testMethod()
            {
                float Destination;
                ExpenumTestClass_ulong_enum_to_float_rtime_s_SrcEnumType Source = ExpenumTestClass_ulong_enum_to_float_rtime_s_SrcEnumType.ValOne;
                Destination = (float)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_ulong_enum_to_int_rtime_s_SrcEnumType : ulong { ValOne = 1 }
        public class ExpenumTestClass_ulong_enum_to_int_rtime_s
        {
            public static bool testMethod()
            {
                int Destination;
                ExpenumTestClass_ulong_enum_to_int_rtime_s_SrcEnumType Source = ExpenumTestClass_ulong_enum_to_int_rtime_s_SrcEnumType.ValOne;
                Destination = (int)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_ulong_enum_to_long_rtime_s_SrcEnumType : ulong { ValOne = 1 }
        public class ExpenumTestClass_ulong_enum_to_long_rtime_s
        {
            public static bool testMethod()
            {
                long Destination;
                ExpenumTestClass_ulong_enum_to_long_rtime_s_SrcEnumType Source = ExpenumTestClass_ulong_enum_to_long_rtime_s_SrcEnumType.ValOne;
                Destination = (long)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_ulong_enum_to_sbyte_rtime_s_SrcEnumType : ulong { ValOne = 1 }
        public class ExpenumTestClass_ulong_enum_to_sbyte_rtime_s
        {
            public static bool testMethod()
            {
                sbyte Destination;
                ExpenumTestClass_ulong_enum_to_sbyte_rtime_s_SrcEnumType Source = ExpenumTestClass_ulong_enum_to_sbyte_rtime_s_SrcEnumType.ValOne;
                Destination = (sbyte)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_ulong_enum_to_short_rtime_s_SrcEnumType : ulong { ValOne = 1 }
        public class ExpenumTestClass_ulong_enum_to_short_rtime_s
        {
            public static bool testMethod()
            {
                short Destination;
                ExpenumTestClass_ulong_enum_to_short_rtime_s_SrcEnumType Source = ExpenumTestClass_ulong_enum_to_short_rtime_s_SrcEnumType.ValOne;
                Destination = (short)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_ulong_enum_to_uint_rtime_s_SrcEnumType : ulong { ValOne = 1 }
        public class ExpenumTestClass_ulong_enum_to_uint_rtime_s
        {
            public static bool testMethod()
            {
                uint Destination;
                ExpenumTestClass_ulong_enum_to_uint_rtime_s_SrcEnumType Source = ExpenumTestClass_ulong_enum_to_uint_rtime_s_SrcEnumType.ValOne;
                Destination = (uint)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_ulong_enum_to_ulong_rtime_s_SrcEnumType : ulong { ValOne = 1 }
        public class ExpenumTestClass_ulong_enum_to_ulong_rtime_s
        {
            public static bool testMethod()
            {
                ulong Destination;
                ExpenumTestClass_ulong_enum_to_ulong_rtime_s_SrcEnumType Source = ExpenumTestClass_ulong_enum_to_ulong_rtime_s_SrcEnumType.ValOne;
                Destination = (ulong)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_ulong_enum_to_ushort_rtime_s_SrcEnumType : ulong { ValOne = 1 }
        public class ExpenumTestClass_ulong_enum_to_ushort_rtime_s
        {
            public static bool testMethod()
            {
                ushort Destination;
                ExpenumTestClass_ulong_enum_to_ushort_rtime_s_SrcEnumType Source = ExpenumTestClass_ulong_enum_to_ushort_rtime_s_SrcEnumType.ValOne;
                Destination = (ushort)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_ushort_enum_to_byte_rtime_s_SrcEnumType : ushort { ValOne = 1 }
        public class ExpenumTestClass_ushort_enum_to_byte_rtime_s
        {
            public static bool testMethod()
            {
                byte Destination;
                ExpenumTestClass_ushort_enum_to_byte_rtime_s_SrcEnumType Source = ExpenumTestClass_ushort_enum_to_byte_rtime_s_SrcEnumType.ValOne;
                Destination = (byte)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_ushort_enum_to_double_rtime_s_SrcEnumType : ushort { ValOne = 1 }
        public class ExpenumTestClass_ushort_enum_to_double_rtime_s
        {
            public static bool testMethod()
            {
                double Destination;
                ExpenumTestClass_ushort_enum_to_double_rtime_s_SrcEnumType Source = ExpenumTestClass_ushort_enum_to_double_rtime_s_SrcEnumType.ValOne;
                Destination = (double)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_ushort_enum_to_float_rtime_s_SrcEnumType : ushort { ValOne = 1 }
        public class ExpenumTestClass_ushort_enum_to_float_rtime_s
        {
            public static bool testMethod()
            {
                float Destination;
                ExpenumTestClass_ushort_enum_to_float_rtime_s_SrcEnumType Source = ExpenumTestClass_ushort_enum_to_float_rtime_s_SrcEnumType.ValOne;
                Destination = (float)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_ushort_enum_to_int_rtime_s_SrcEnumType : ushort { ValOne = 1 }
        public class ExpenumTestClass_ushort_enum_to_int_rtime_s
        {
            public static bool testMethod()
            {
                int Destination;
                ExpenumTestClass_ushort_enum_to_int_rtime_s_SrcEnumType Source = ExpenumTestClass_ushort_enum_to_int_rtime_s_SrcEnumType.ValOne;
                Destination = (int)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_ushort_enum_to_long_rtime_s_SrcEnumType : ushort { ValOne = 1 }
        public class ExpenumTestClass_ushort_enum_to_long_rtime_s
        {
            public static bool testMethod()
            {
                long Destination;
                ExpenumTestClass_ushort_enum_to_long_rtime_s_SrcEnumType Source = ExpenumTestClass_ushort_enum_to_long_rtime_s_SrcEnumType.ValOne;
                Destination = (long)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_ushort_enum_to_sbyte_rtime_s_SrcEnumType : ushort { ValOne = 1 }
        public class ExpenumTestClass_ushort_enum_to_sbyte_rtime_s
        {
            public static bool testMethod()
            {
                sbyte Destination;
                ExpenumTestClass_ushort_enum_to_sbyte_rtime_s_SrcEnumType Source = ExpenumTestClass_ushort_enum_to_sbyte_rtime_s_SrcEnumType.ValOne;
                Destination = (sbyte)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_ushort_enum_to_short_rtime_s_SrcEnumType : ushort { ValOne = 1 }
        public class ExpenumTestClass_ushort_enum_to_short_rtime_s
        {
            public static bool testMethod()
            {
                short Destination;
                ExpenumTestClass_ushort_enum_to_short_rtime_s_SrcEnumType Source = ExpenumTestClass_ushort_enum_to_short_rtime_s_SrcEnumType.ValOne;
                Destination = (short)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_ushort_enum_to_uint_rtime_s_SrcEnumType : ushort { ValOne = 1 }
        public class ExpenumTestClass_ushort_enum_to_uint_rtime_s
        {
            public static bool testMethod()
            {
                uint Destination;
                ExpenumTestClass_ushort_enum_to_uint_rtime_s_SrcEnumType Source = ExpenumTestClass_ushort_enum_to_uint_rtime_s_SrcEnumType.ValOne;
                Destination = (uint)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_ushort_enum_to_ulong_rtime_s_SrcEnumType : ushort { ValOne = 1 }
        public class ExpenumTestClass_ushort_enum_to_ulong_rtime_s
        {
            public static bool testMethod()
            {
                ulong Destination;
                ExpenumTestClass_ushort_enum_to_ulong_rtime_s_SrcEnumType Source = ExpenumTestClass_ushort_enum_to_ulong_rtime_s_SrcEnumType.ValOne;
                Destination = (ulong)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_ushort_enum_to_ushort_rtime_s_SrcEnumType : ushort { ValOne = 1 }
        public class ExpenumTestClass_ushort_enum_to_ushort_rtime_s
        {
            public static bool testMethod()
            {
                ushort Destination;
                ExpenumTestClass_ushort_enum_to_ushort_rtime_s_SrcEnumType Source = ExpenumTestClass_ushort_enum_to_ushort_rtime_s_SrcEnumType.ValOne;
                Destination = (ushort)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_byte_enum_to_byte_rtime_s_SrcEnumType : byte { ValOne = 1 }
        public class ExpenumTestClass_byte_enum_to_byte_rtime_s
        {
            public static bool testMethod()
            {
                byte Destination;
                ExpenumTestClass_byte_enum_to_byte_rtime_s_SrcEnumType Source = ExpenumTestClass_byte_enum_to_byte_rtime_s_SrcEnumType.ValOne;
                Destination = (byte)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_byte_enum_to_double_rtime_s_SrcEnumType : byte { ValOne = 1 }
        public class ExpenumTestClass_byte_enum_to_double_rtime_s
        {
            public static bool testMethod()
            {
                double Destination;
                ExpenumTestClass_byte_enum_to_double_rtime_s_SrcEnumType Source = ExpenumTestClass_byte_enum_to_double_rtime_s_SrcEnumType.ValOne;
                Destination = (double)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_byte_enum_to_float_rtime_s_SrcEnumType : byte { ValOne = 1 }
        public class ExpenumTestClass_byte_enum_to_float_rtime_s
        {
            public static bool testMethod()
            {
                float Destination;
                ExpenumTestClass_byte_enum_to_float_rtime_s_SrcEnumType Source = ExpenumTestClass_byte_enum_to_float_rtime_s_SrcEnumType.ValOne;
                Destination = (float)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_byte_enum_to_int_rtime_s_SrcEnumType : byte { ValOne = 1 }
        public class ExpenumTestClass_byte_enum_to_int_rtime_s
        {
            public static bool testMethod()
            {
                int Destination;
                ExpenumTestClass_byte_enum_to_int_rtime_s_SrcEnumType Source = ExpenumTestClass_byte_enum_to_int_rtime_s_SrcEnumType.ValOne;
                Destination = (int)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_byte_enum_to_long_rtime_s_SrcEnumType : byte { ValOne = 1 }
        public class ExpenumTestClass_byte_enum_to_long_rtime_s
        {
            public static bool testMethod()
            {
                long Destination;
                ExpenumTestClass_byte_enum_to_long_rtime_s_SrcEnumType Source = ExpenumTestClass_byte_enum_to_long_rtime_s_SrcEnumType.ValOne;
                Destination = (long)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_byte_enum_to_sbyte_rtime_s_SrcEnumType : byte { ValOne = 1 }
        public class ExpenumTestClass_byte_enum_to_sbyte_rtime_s
        {
            public static bool testMethod()
            {
                sbyte Destination;
                ExpenumTestClass_byte_enum_to_sbyte_rtime_s_SrcEnumType Source = ExpenumTestClass_byte_enum_to_sbyte_rtime_s_SrcEnumType.ValOne;
                Destination = (sbyte)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_byte_enum_to_short_rtime_s_SrcEnumType : byte { ValOne = 1 }
        public class ExpenumTestClass_byte_enum_to_short_rtime_s
        {
            public static bool testMethod()
            {
                short Destination;
                ExpenumTestClass_byte_enum_to_short_rtime_s_SrcEnumType Source = ExpenumTestClass_byte_enum_to_short_rtime_s_SrcEnumType.ValOne;
                Destination = (short)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_byte_enum_to_uint_rtime_s_SrcEnumType : byte { ValOne = 1 }
        public class ExpenumTestClass_byte_enum_to_uint_rtime_s
        {
            public static bool testMethod()
            {
                uint Destination;
                ExpenumTestClass_byte_enum_to_uint_rtime_s_SrcEnumType Source = ExpenumTestClass_byte_enum_to_uint_rtime_s_SrcEnumType.ValOne;
                Destination = (uint)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_byte_enum_to_ulong_rtime_s_SrcEnumType : byte { ValOne = 1 }
        public class ExpenumTestClass_byte_enum_to_ulong_rtime_s
        {
            public static bool testMethod()
            {
                ulong Destination;
                ExpenumTestClass_byte_enum_to_ulong_rtime_s_SrcEnumType Source = ExpenumTestClass_byte_enum_to_ulong_rtime_s_SrcEnumType.ValOne;
                Destination = (ulong)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_byte_enum_to_ushort_rtime_s_SrcEnumType : byte { ValOne = 1 }
        public class ExpenumTestClass_byte_enum_to_ushort_rtime_s
        {
            public static bool testMethod()
            {
                ushort Destination;
                ExpenumTestClass_byte_enum_to_ushort_rtime_s_SrcEnumType Source = ExpenumTestClass_byte_enum_to_ushort_rtime_s_SrcEnumType.ValOne;
                Destination = (ushort)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_int_enum_to_byte_rtime_s_SrcEnumType : int { ValOne = 1 }
        public class ExpenumTestClass_int_enum_to_byte_rtime_s
        {
            public static bool testMethod()
            {
                byte Destination;
                ExpenumTestClass_int_enum_to_byte_rtime_s_SrcEnumType Source = ExpenumTestClass_int_enum_to_byte_rtime_s_SrcEnumType.ValOne;
                Destination = (byte)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_int_enum_to_double_rtime_s_SrcEnumType : int { ValOne = 1 }
        public class ExpenumTestClass_int_enum_to_double_rtime_s
        {
            public static bool testMethod()
            {
                double Destination;
                ExpenumTestClass_int_enum_to_double_rtime_s_SrcEnumType Source = ExpenumTestClass_int_enum_to_double_rtime_s_SrcEnumType.ValOne;
                Destination = (double)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_int_enum_to_float_rtime_s_SrcEnumType : int { ValOne = 1 }
        public class ExpenumTestClass_int_enum_to_float_rtime_s
        {
            public static bool testMethod()
            {
                float Destination;
                ExpenumTestClass_int_enum_to_float_rtime_s_SrcEnumType Source = ExpenumTestClass_int_enum_to_float_rtime_s_SrcEnumType.ValOne;
                Destination = (float)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_int_enum_to_int_rtime_s_SrcEnumType : int { ValOne = 1 }
        public class ExpenumTestClass_int_enum_to_int_rtime_s
        {
            public static bool testMethod()
            {
                int Destination;
                ExpenumTestClass_int_enum_to_int_rtime_s_SrcEnumType Source = ExpenumTestClass_int_enum_to_int_rtime_s_SrcEnumType.ValOne;
                Destination = (int)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_int_enum_to_long_rtime_s_SrcEnumType : int { ValOne = 1 }
        public class ExpenumTestClass_int_enum_to_long_rtime_s
        {
            public static bool testMethod()
            {
                long Destination;
                ExpenumTestClass_int_enum_to_long_rtime_s_SrcEnumType Source = ExpenumTestClass_int_enum_to_long_rtime_s_SrcEnumType.ValOne;
                Destination = (long)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_int_enum_to_sbyte_rtime_s_SrcEnumType : int { ValOne = 1 }
        public class ExpenumTestClass_int_enum_to_sbyte_rtime_s
        {
            public static bool testMethod()
            {
                sbyte Destination;
                ExpenumTestClass_int_enum_to_sbyte_rtime_s_SrcEnumType Source = ExpenumTestClass_int_enum_to_sbyte_rtime_s_SrcEnumType.ValOne;
                Destination = (sbyte)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_int_enum_to_short_rtime_s_SrcEnumType : int { ValOne = 1 }
        public class ExpenumTestClass_int_enum_to_short_rtime_s
        {
            public static bool testMethod()
            {
                short Destination;
                ExpenumTestClass_int_enum_to_short_rtime_s_SrcEnumType Source = ExpenumTestClass_int_enum_to_short_rtime_s_SrcEnumType.ValOne;
                Destination = (short)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_int_enum_to_uint_rtime_s_SrcEnumType : int { ValOne = 1 }
        public class ExpenumTestClass_int_enum_to_uint_rtime_s
        {
            public static bool testMethod()
            {
                uint Destination;
                ExpenumTestClass_int_enum_to_uint_rtime_s_SrcEnumType Source = ExpenumTestClass_int_enum_to_uint_rtime_s_SrcEnumType.ValOne;
                Destination = (uint)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_int_enum_to_ulong_rtime_s_SrcEnumType : int { ValOne = 1 }
        public class ExpenumTestClass_int_enum_to_ulong_rtime_s
        {
            public static bool testMethod()
            {
                ulong Destination;
                ExpenumTestClass_int_enum_to_ulong_rtime_s_SrcEnumType Source = ExpenumTestClass_int_enum_to_ulong_rtime_s_SrcEnumType.ValOne;
                Destination = (ulong)Source;
                if (Destination == 1)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_int_enum_to_ulong_enum_rtime_s_DestEnumType : ulong { ValOne = 1 }
        enum ExpenumTestClass_int_enum_to_ulong_enum_rtime_s_SrcEnumType : int { ValOne = 1 }
        public class ExpenumTestClass_int_enum_to_ulong_enum_rtime_s
        {
            public static bool testMethod()
            {
                ExpenumTestClass_int_enum_to_ulong_enum_rtime_s_DestEnumType Destination;
                ExpenumTestClass_int_enum_to_ulong_enum_rtime_s_SrcEnumType Source = ExpenumTestClass_int_enum_to_ulong_enum_rtime_s_SrcEnumType.ValOne;
                Destination = (ExpenumTestClass_int_enum_to_ulong_enum_rtime_s_DestEnumType)Source;
                if (Destination == ExpenumTestClass_int_enum_to_ulong_enum_rtime_s_DestEnumType.ValOne)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_int_enum_to_ushort_enum_rtime_s_DestEnumType : ushort { ValOne = 1 }
        enum ExpenumTestClass_int_enum_to_ushort_enum_rtime_s_SrcEnumType : int { ValOne = 1 }
        public class ExpenumTestClass_int_enum_to_ushort_enum_rtime_s
        {
            public static bool testMethod()
            {
                ExpenumTestClass_int_enum_to_ushort_enum_rtime_s_DestEnumType Destination;
                ExpenumTestClass_int_enum_to_ushort_enum_rtime_s_SrcEnumType Source = ExpenumTestClass_int_enum_to_ushort_enum_rtime_s_SrcEnumType.ValOne;
                Destination = (ExpenumTestClass_int_enum_to_ushort_enum_rtime_s_DestEnumType)Source;
                if (Destination == ExpenumTestClass_int_enum_to_ushort_enum_rtime_s_DestEnumType.ValOne)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_long_enum_to_byte_enum_rtime_s_DestEnumType : byte { ValOne = 1 }
        enum ExpenumTestClass_long_enum_to_byte_enum_rtime_s_SrcEnumType : long { ValOne = 1 }
        public class ExpenumTestClass_long_enum_to_byte_enum_rtime_s
        {
            public static bool testMethod()
            {
                ExpenumTestClass_long_enum_to_byte_enum_rtime_s_DestEnumType Destination;
                ExpenumTestClass_long_enum_to_byte_enum_rtime_s_SrcEnumType Source = ExpenumTestClass_long_enum_to_byte_enum_rtime_s_SrcEnumType.ValOne;
                Destination = (ExpenumTestClass_long_enum_to_byte_enum_rtime_s_DestEnumType)Source;
                if (Destination == ExpenumTestClass_long_enum_to_byte_enum_rtime_s_DestEnumType.ValOne)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_long_enum_to_int_enum_rtime_s_DestEnumType : int { ValOne = 1 }
        enum ExpenumTestClass_long_enum_to_int_enum_rtime_s_SrcEnumType : long { ValOne = 1 }
        public class ExpenumTestClass_long_enum_to_int_enum_rtime_s
        {
            public static bool testMethod()
            {
                ExpenumTestClass_long_enum_to_int_enum_rtime_s_DestEnumType Destination;
                ExpenumTestClass_long_enum_to_int_enum_rtime_s_SrcEnumType Source = ExpenumTestClass_long_enum_to_int_enum_rtime_s_SrcEnumType.ValOne;
                Destination = (ExpenumTestClass_long_enum_to_int_enum_rtime_s_DestEnumType)Source;
                if (Destination == ExpenumTestClass_long_enum_to_int_enum_rtime_s_DestEnumType.ValOne)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_long_enum_to_long_enum_rtime_s_DestEnumType : long { ValOne = 1 }
        enum ExpenumTestClass_long_enum_to_long_enum_rtime_s_SrcEnumType : long { ValOne = 1 }
        public class ExpenumTestClass_long_enum_to_long_enum_rtime_s
        {
            public static bool testMethod()
            {
                ExpenumTestClass_long_enum_to_long_enum_rtime_s_DestEnumType Destination;
                ExpenumTestClass_long_enum_to_long_enum_rtime_s_SrcEnumType Source = ExpenumTestClass_long_enum_to_long_enum_rtime_s_SrcEnumType.ValOne;
                Destination = (ExpenumTestClass_long_enum_to_long_enum_rtime_s_DestEnumType)Source;
                if (Destination == ExpenumTestClass_long_enum_to_long_enum_rtime_s_DestEnumType.ValOne)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_long_enum_to_sbyte_enum_rtime_s_DestEnumType : sbyte { ValOne = 1 }
        enum ExpenumTestClass_long_enum_to_sbyte_enum_rtime_s_SrcEnumType : long { ValOne = 1 }
        public class ExpenumTestClass_long_enum_to_sbyte_enum_rtime_s
        {
            public static bool testMethod()
            {
                ExpenumTestClass_long_enum_to_sbyte_enum_rtime_s_DestEnumType Destination;
                ExpenumTestClass_long_enum_to_sbyte_enum_rtime_s_SrcEnumType Source = ExpenumTestClass_long_enum_to_sbyte_enum_rtime_s_SrcEnumType.ValOne;
                Destination = (ExpenumTestClass_long_enum_to_sbyte_enum_rtime_s_DestEnumType)Source;
                if (Destination == ExpenumTestClass_long_enum_to_sbyte_enum_rtime_s_DestEnumType.ValOne)
                    return true;
                else
                    return false;
            }
        }
        
        enum ExpenumTestClass_long_enum_to_short_enum_rtime_s_DestEnumType : short { ValOne = 1 }
        enum ExpenumTestClass_long_enum_to_short_enum_rtime_s_SrcEnumType : long { ValOne = 1 }
        public class ExpenumTestClass_long_enum_to_short_enum_rtime_s
        {
            public static bool testMethod()
            {
                ExpenumTestClass_long_enum_to_short_enum_rtime_s_DestEnumType Destination;
                ExpenumTestClass_long_enum_to_short_enum_rtime_s_SrcEnumType Source = ExpenumTestClass_long_enum_to_short_enum_rtime_s_SrcEnumType.ValOne;
                Destination = (ExpenumTestClass_long_enum_to_short_enum_rtime_s_DestEnumType)Source;
                if (Destination == ExpenumTestClass_long_enum_to_short_enum_rtime_s_DestEnumType.ValOne)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_long_enum_to_uint_enum_rtime_s_DestEnumType : uint { ValOne = 1 }
        enum ExpenumTestClass_long_enum_to_uint_enum_rtime_s_SrcEnumType : long { ValOne = 1 }
        public class ExpenumTestClass_long_enum_to_uint_enum_rtime_s
        {
            public static bool testMethod()
            {
                ExpenumTestClass_long_enum_to_uint_enum_rtime_s_DestEnumType Destination;
                ExpenumTestClass_long_enum_to_uint_enum_rtime_s_SrcEnumType Source = ExpenumTestClass_long_enum_to_uint_enum_rtime_s_SrcEnumType.ValOne;
                Destination = (ExpenumTestClass_long_enum_to_uint_enum_rtime_s_DestEnumType)Source;
                if (Destination == ExpenumTestClass_long_enum_to_uint_enum_rtime_s_DestEnumType.ValOne)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_long_enum_to_ulong_enum_rtime_s_DestEnumType : ulong { ValOne = 1 }
        enum ExpenumTestClass_long_enum_to_ulong_enum_rtime_s_SrcEnumType : long { ValOne = 1 }
        public class ExpenumTestClass_long_enum_to_ulong_enum_rtime_s
        {
            public static bool testMethod()
            {
                ExpenumTestClass_long_enum_to_ulong_enum_rtime_s_DestEnumType Destination;
                ExpenumTestClass_long_enum_to_ulong_enum_rtime_s_SrcEnumType Source = ExpenumTestClass_long_enum_to_ulong_enum_rtime_s_SrcEnumType.ValOne;
                Destination = (ExpenumTestClass_long_enum_to_ulong_enum_rtime_s_DestEnumType)Source;
                if (Destination == ExpenumTestClass_long_enum_to_ulong_enum_rtime_s_DestEnumType.ValOne)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_long_enum_to_ushort_enum_rtime_s_DestEnumType : ushort { ValOne = 1 }
        enum ExpenumTestClass_long_enum_to_ushort_enum_rtime_s_SrcEnumType : long { ValOne = 1 }
        public class ExpenumTestClass_long_enum_to_ushort_enum_rtime_s
        {
            public static bool testMethod()
            {
                ExpenumTestClass_long_enum_to_ushort_enum_rtime_s_DestEnumType Destination;
                ExpenumTestClass_long_enum_to_ushort_enum_rtime_s_SrcEnumType Source = ExpenumTestClass_long_enum_to_ushort_enum_rtime_s_SrcEnumType.ValOne;
                Destination = (ExpenumTestClass_long_enum_to_ushort_enum_rtime_s_DestEnumType)Source;
                if (Destination == ExpenumTestClass_long_enum_to_ushort_enum_rtime_s_DestEnumType.ValOne)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_sbyte_enum_to_byte_enum_rtime_s_DestEnumType : byte { ValOne = 1 }
        enum ExpenumTestClass_sbyte_enum_to_byte_enum_rtime_s_SrcEnumType : sbyte { ValOne = 1 }
        public class ExpenumTestClass_sbyte_enum_to_byte_enum_rtime_s
        {
            public static bool testMethod()
            {
                ExpenumTestClass_sbyte_enum_to_byte_enum_rtime_s_DestEnumType Destination;
                ExpenumTestClass_sbyte_enum_to_byte_enum_rtime_s_SrcEnumType Source = ExpenumTestClass_sbyte_enum_to_byte_enum_rtime_s_SrcEnumType.ValOne;
                Destination = (ExpenumTestClass_sbyte_enum_to_byte_enum_rtime_s_DestEnumType)Source;
                if (Destination == ExpenumTestClass_sbyte_enum_to_byte_enum_rtime_s_DestEnumType.ValOne)
                    return true;
                else
                    return false;
            }
        }
        
        enum ExpenumTestClass_sbyte_enum_to_int_enum_rtime_s_DestEnumType : int { ValOne = 1 }
        enum ExpenumTestClass_sbyte_enum_to_int_enum_rtime_s_SrcEnumType : sbyte { ValOne = 1 }
        public class ExpenumTestClass_sbyte_enum_to_int_enum_rtime_s
        {
            public static bool testMethod()
            {
                ExpenumTestClass_sbyte_enum_to_int_enum_rtime_s_DestEnumType Destination;
                ExpenumTestClass_sbyte_enum_to_int_enum_rtime_s_SrcEnumType Source = ExpenumTestClass_sbyte_enum_to_int_enum_rtime_s_SrcEnumType.ValOne;
                Destination = (ExpenumTestClass_sbyte_enum_to_int_enum_rtime_s_DestEnumType)Source;
                if (Destination == ExpenumTestClass_sbyte_enum_to_int_enum_rtime_s_DestEnumType.ValOne)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_sbyte_enum_to_long_enum_rtime_s_DestEnumType : long { ValOne = 1 }
        enum ExpenumTestClass_sbyte_enum_to_long_enum_rtime_s_SrcEnumType : sbyte { ValOne = 1 }
        public class ExpenumTestClass_sbyte_enum_to_long_enum_rtime_s
        {
            public static bool testMethod()
            {
                ExpenumTestClass_sbyte_enum_to_long_enum_rtime_s_DestEnumType Destination;
                ExpenumTestClass_sbyte_enum_to_long_enum_rtime_s_SrcEnumType Source = ExpenumTestClass_sbyte_enum_to_long_enum_rtime_s_SrcEnumType.ValOne;
                Destination = (ExpenumTestClass_sbyte_enum_to_long_enum_rtime_s_DestEnumType)Source;
                if (Destination == ExpenumTestClass_sbyte_enum_to_long_enum_rtime_s_DestEnumType.ValOne)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_sbyte_enum_to_sbyte_enum_rtime_s_DestEnumType : sbyte { ValOne = 1 }
        enum ExpenumTestClass_sbyte_enum_to_sbyte_enum_rtime_s_SrcEnumType : sbyte { ValOne = 1 }
        public class ExpenumTestClass_sbyte_enum_to_sbyte_enum_rtime_s
        {
            public static bool testMethod()
            {
                ExpenumTestClass_sbyte_enum_to_sbyte_enum_rtime_s_DestEnumType Destination;
                ExpenumTestClass_sbyte_enum_to_sbyte_enum_rtime_s_SrcEnumType Source = ExpenumTestClass_sbyte_enum_to_sbyte_enum_rtime_s_SrcEnumType.ValOne;
                Destination = (ExpenumTestClass_sbyte_enum_to_sbyte_enum_rtime_s_DestEnumType)Source;
                if (Destination == ExpenumTestClass_sbyte_enum_to_sbyte_enum_rtime_s_DestEnumType.ValOne)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_sbyte_enum_to_short_enum_rtime_s_DestEnumType : short { ValOne = 1 }
        enum ExpenumTestClass_sbyte_enum_to_short_enum_rtime_s_SrcEnumType : sbyte { ValOne = 1 }
        public class ExpenumTestClass_sbyte_enum_to_short_enum_rtime_s
        {
            public static bool testMethod()
            {
                ExpenumTestClass_sbyte_enum_to_short_enum_rtime_s_DestEnumType Destination;
                ExpenumTestClass_sbyte_enum_to_short_enum_rtime_s_SrcEnumType Source = ExpenumTestClass_sbyte_enum_to_short_enum_rtime_s_SrcEnumType.ValOne;
                Destination = (ExpenumTestClass_sbyte_enum_to_short_enum_rtime_s_DestEnumType)Source;
                if (Destination == ExpenumTestClass_sbyte_enum_to_short_enum_rtime_s_DestEnumType.ValOne)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_sbyte_enum_to_uint_enum_rtime_s_DestEnumType : uint { ValOne = 1 }
        enum ExpenumTestClass_sbyte_enum_to_uint_enum_rtime_s_SrcEnumType : sbyte { ValOne = 1 }
        public class ExpenumTestClass_sbyte_enum_to_uint_enum_rtime_s
        {
            public static bool testMethod()
            {
                ExpenumTestClass_sbyte_enum_to_uint_enum_rtime_s_DestEnumType Destination;
                ExpenumTestClass_sbyte_enum_to_uint_enum_rtime_s_SrcEnumType Source = ExpenumTestClass_sbyte_enum_to_uint_enum_rtime_s_SrcEnumType.ValOne;
                Destination = (ExpenumTestClass_sbyte_enum_to_uint_enum_rtime_s_DestEnumType)Source;
                if (Destination == ExpenumTestClass_sbyte_enum_to_uint_enum_rtime_s_DestEnumType.ValOne)
                    return true;
                else
                    return false;
            }
        }
        
        enum ExpenumTestClass_byte_enum_to_ulong_enum_rtime_s_DestEnumType : ulong { ValOne = 1 }
        enum ExpenumTestClass_byte_enum_to_ulong_enum_rtime_s_SrcEnumType : byte { ValOne = 1 }
        public class ExpenumTestClass_byte_enum_to_ulong_enum_rtime_s
        {
            public static bool testMethod()
            {
                ExpenumTestClass_byte_enum_to_ulong_enum_rtime_s_DestEnumType Destination;
                ExpenumTestClass_byte_enum_to_ulong_enum_rtime_s_SrcEnumType Source = ExpenumTestClass_byte_enum_to_ulong_enum_rtime_s_SrcEnumType.ValOne;
                Destination = (ExpenumTestClass_byte_enum_to_ulong_enum_rtime_s_DestEnumType)Source;
                if (Destination == ExpenumTestClass_byte_enum_to_ulong_enum_rtime_s_DestEnumType.ValOne)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_byte_enum_to_ushort_enum_rtime_s_DestEnumType : ushort { ValOne = 1 }
        enum ExpenumTestClass_byte_enum_to_ushort_enum_rtime_s_SrcEnumType : byte { ValOne = 1 }
        public class ExpenumTestClass_byte_enum_to_ushort_enum_rtime_s
        {
            public static bool testMethod()
            {
                ExpenumTestClass_byte_enum_to_ushort_enum_rtime_s_DestEnumType Destination;
                ExpenumTestClass_byte_enum_to_ushort_enum_rtime_s_SrcEnumType Source = ExpenumTestClass_byte_enum_to_ushort_enum_rtime_s_SrcEnumType.ValOne;
                Destination = (ExpenumTestClass_byte_enum_to_ushort_enum_rtime_s_DestEnumType)Source;
                if (Destination == ExpenumTestClass_byte_enum_to_ushort_enum_rtime_s_DestEnumType.ValOne)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_int_enum_to_byte_enum_rtime_s_DestEnumType : byte { ValOne = 1 }
        enum ExpenumTestClass_int_enum_to_byte_enum_rtime_s_SrcEnumType : int { ValOne = 1 }
        public class ExpenumTestClass_int_enum_to_byte_enum_rtime_s
        {
            public static bool testMethod()
            {
                ExpenumTestClass_int_enum_to_byte_enum_rtime_s_DestEnumType Destination;
                ExpenumTestClass_int_enum_to_byte_enum_rtime_s_SrcEnumType Source = ExpenumTestClass_int_enum_to_byte_enum_rtime_s_SrcEnumType.ValOne;
                Destination = (ExpenumTestClass_int_enum_to_byte_enum_rtime_s_DestEnumType)Source;
                if (Destination == ExpenumTestClass_int_enum_to_byte_enum_rtime_s_DestEnumType.ValOne)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_int_enum_to_int_enum_rtime_s_DestEnumType : int { ValOne = 1 }
        enum ExpenumTestClass_int_enum_to_int_enum_rtime_s_SrcEnumType : int { ValOne = 1 }
        public class ExpenumTestClass_int_enum_to_int_enum_rtime_s
        {
            public static bool testMethod()
            {
                ExpenumTestClass_int_enum_to_int_enum_rtime_s_DestEnumType Destination;
                ExpenumTestClass_int_enum_to_int_enum_rtime_s_SrcEnumType Source = ExpenumTestClass_int_enum_to_int_enum_rtime_s_SrcEnumType.ValOne;
                Destination = (ExpenumTestClass_int_enum_to_int_enum_rtime_s_DestEnumType)Source;
                if (Destination == ExpenumTestClass_int_enum_to_int_enum_rtime_s_DestEnumType.ValOne)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_int_enum_to_long_enum_rtime_s_DestEnumType : long { ValOne = 1 }
        enum ExpenumTestClass_int_enum_to_long_enum_rtime_s_SrcEnumType : int { ValOne = 1 }
        public class ExpenumTestClass_int_enum_to_long_enum_rtime_s
        {
            public static bool testMethod()
            {
                ExpenumTestClass_int_enum_to_long_enum_rtime_s_DestEnumType Destination;
                ExpenumTestClass_int_enum_to_long_enum_rtime_s_SrcEnumType Source = ExpenumTestClass_int_enum_to_long_enum_rtime_s_SrcEnumType.ValOne;
                Destination = (ExpenumTestClass_int_enum_to_long_enum_rtime_s_DestEnumType)Source;
                if (Destination == ExpenumTestClass_int_enum_to_long_enum_rtime_s_DestEnumType.ValOne)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_int_enum_to_sbyte_enum_rtime_s_DestEnumType : sbyte { ValOne = 1 }
        enum ExpenumTestClass_int_enum_to_sbyte_enum_rtime_s_SrcEnumType : int { ValOne = 1 }
        public class ExpenumTestClass_int_enum_to_sbyte_enum_rtime_s
        {
            public static bool testMethod()
            {
                ExpenumTestClass_int_enum_to_sbyte_enum_rtime_s_DestEnumType Destination;
                ExpenumTestClass_int_enum_to_sbyte_enum_rtime_s_SrcEnumType Source = ExpenumTestClass_int_enum_to_sbyte_enum_rtime_s_SrcEnumType.ValOne;
                Destination = (ExpenumTestClass_int_enum_to_sbyte_enum_rtime_s_DestEnumType)Source;
                if (Destination == ExpenumTestClass_int_enum_to_sbyte_enum_rtime_s_DestEnumType.ValOne)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_int_enum_to_short_enum_rtime_s_DestEnumType : short { ValOne = 1 }
        enum ExpenumTestClass_int_enum_to_short_enum_rtime_s_SrcEnumType : int { ValOne = 1 }
        public class ExpenumTestClass_int_enum_to_short_enum_rtime_s
        {
            public static bool testMethod()
            {
                ExpenumTestClass_int_enum_to_short_enum_rtime_s_DestEnumType Destination;
                ExpenumTestClass_int_enum_to_short_enum_rtime_s_SrcEnumType Source = ExpenumTestClass_int_enum_to_short_enum_rtime_s_SrcEnumType.ValOne;
                Destination = (ExpenumTestClass_int_enum_to_short_enum_rtime_s_DestEnumType)Source;
                if (Destination == ExpenumTestClass_int_enum_to_short_enum_rtime_s_DestEnumType.ValOne)
                    return true;
                else
                    return false;
            }
        }
        enum ExpenumTestClass_int_enum_to_uint_enum_rtime_s_DestEnumType : uint { ValOne = 1 }
        enum ExpenumTestClass_int_enum_to_uint_enum_rtime_s_SrcEnumType : int { ValOne = 1 }
        public class ExpenumTestClass_int_enum_to_uint_enum_rtime_s
        {
            public static bool testMethod()
            {
                ExpenumTestClass_int_enum_to_uint_enum_rtime_s_DestEnumType Destination;
                ExpenumTestClass_int_enum_to_uint_enum_rtime_s_SrcEnumType Source = ExpenumTestClass_int_enum_to_uint_enum_rtime_s_SrcEnumType.ValOne;
                Destination = (ExpenumTestClass_int_enum_to_uint_enum_rtime_s_DestEnumType)Source;
                if (Destination == ExpenumTestClass_int_enum_to_uint_enum_rtime_s_DestEnumType.ValOne)
                    return true;
                else
                    return false;
            }
        }
        
    }
}
