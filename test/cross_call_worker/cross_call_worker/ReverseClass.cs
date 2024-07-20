﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using static cross_call_master.cross_call_master;

namespace cross_call_worker
{
    public class ReverseClass
    {
        public static string ReverseNoParamReturnVoid()
        {
            NoParamReturnVoidCallback();
            return string.Empty;
        }

        public static string ReverseNoParamReturnBool()
        {
            bool result = NoParamReturnBoolCallback();
            return result ? "true" : "false";
        }

        public static string ReverseNoParamReturnChar8()
        {
            char result = NoParamReturnChar8Callback();
            return ((int)result).ToString();
        }

        public static string ReverseNoParamReturnChar16()
        {
            char result = NoParamReturnChar16Callback();
            return ((int)result).ToString();
        }

        public static string ReverseNoParamReturnInt8()
        {
            sbyte result = NoParamReturnInt8Callback();
            return result.ToString();
        }

        public static string ReverseNoParamReturnInt16()
        {
            short result = NoParamReturnInt16Callback();
            return result.ToString();
        }

        public static string ReverseNoParamReturnInt32()
        {
            int result = NoParamReturnInt32Callback();
            return result.ToString();
        }

        public static string ReverseNoParamReturnInt64()
        {
            long result = NoParamReturnInt64Callback();
            return result.ToString();
        }

        public static string ReverseNoParamReturnUInt8()
        {
            byte result = NoParamReturnUInt8Callback();
            return result.ToString();
        }

        public static string ReverseNoParamReturnUInt16()
        {
            ushort result = NoParamReturnUInt16Callback();
            return result.ToString();
        }

        public static string ReverseNoParamReturnUInt32()
        {
            uint result = NoParamReturnUInt32Callback();
            return result.ToString();
        }

        public static string ReverseNoParamReturnUInt64()
        {
           ulong result = NoParamReturnUInt64Callback();
            return result.ToString();
        }

        public static string ReverseNoParamReturnPointer()
        {
            IntPtr result = NoParamReturnPointerCallback();
            return "0x" + result.ToString("x");
        }

        public static string ReverseNoParamReturnFloat()
        {
            float result = NoParamReturnFloatCallback();
            return result.ToString("F3");
        }

        public static string ReverseNoParamReturnDouble()
        {
            double result = NoParamReturnDoubleCallback();
            return result.ToString();
        }

        delegate int NoParamReturnFunctionCallbackFunc();
        
        public static string ReverseNoParamReturnFunction()
        {
            var func = NoParamReturnFunctionCallback();
            return func().ToString();
        }

        public static string ReverseNoParamReturnString()
        {
            string result = NoParamReturnStringCallback();
            return result;
        }

        public static string ReverseNoParamReturnArrayBool()
        {
            bool[] result = NoParamReturnArrayBoolCallback();
            return $"{{{string.Join(", ", result.Select(v => v.ToString().ToLower()))}}}";
        }

        public static string ReverseNoParamReturnArrayChar8()
        {
            char[] result = NoParamReturnArrayChar8Callback();
            return $"{{{string.Join(", ", result.Select(v => ((int)v).ToString()))}}}";
        }

        public static string ReverseNoParamReturnArrayChar16()
        {
            char[] result = NoParamReturnArrayChar16Callback();
            return $"{{{string.Join(", ", result.Select(v => ((int)v).ToString()))}}}";
        }

        public static string ReverseNoParamReturnArrayInt8()
        {
            sbyte[] result = NoParamReturnArrayInt8Callback();
            return $"{{{string.Join(", ", result)}}}";
        }

        public static string ReverseNoParamReturnArrayInt16()
        {
            short[] result = NoParamReturnArrayInt16Callback();
            return $"{{{string.Join(", ", result)}}}";
        }

        public static string ReverseNoParamReturnArrayInt32()
        {
            int[] result = NoParamReturnArrayInt32Callback();
            return $"{{{string.Join(", ", result)}}}";
        }

        public static string ReverseNoParamReturnArrayInt64()
        {
            long[] result = NoParamReturnArrayInt64Callback();
            return $"{{{string.Join(", ", result)}}}";
        }

        public static string ReverseNoParamReturnArrayUInt8()
        {
            byte[] result = NoParamReturnArrayUInt8Callback();
            return $"{{{string.Join(", ", result)}}}";
        }

        public static string ReverseNoParamReturnArrayUInt16()
        {
            ushort[] result = NoParamReturnArrayUInt16Callback();
            return $"{{{string.Join(", ", result)}}}";
        }

        public static string ReverseNoParamReturnArrayUInt32()
        {
            uint[] result = NoParamReturnArrayUInt32Callback();
            return $"{{{string.Join(", ", result)}}}";
        }

        public static string ReverseNoParamReturnArrayUInt64()
        {
            ulong[] result = NoParamReturnArrayUInt64Callback();
            return $"{{{string.Join(", ", result)}}}";
        }

        public static string ReverseNoParamReturnArrayPointer()
        {
            IntPtr[] result = NoParamReturnArrayPointerCallback();
            return $"{{{string.Join(", ", result.Select(v =>  "0x" + v.ToString("x")))}}}";
        }

        public static string ReverseNoParamReturnArrayFloat()
        {
            float[] result = NoParamReturnArrayFloatCallback();
            return $"{{{string.Join(", ", result.Select(v => v.ToString("F3").TrimEnd('0').TrimEnd('.')))}}}";
        }

        public static string ReverseNoParamReturnArrayDouble()
        {
            double[] result = NoParamReturnArrayDoubleCallback();
            return $"{{{string.Join(", ", result)}}}";
        }

        public static string ReverseNoParamReturnArrayString()
        {
            string[] result = NoParamReturnArrayStringCallback();
            return $"{{{string.Join(", ", result.Select(v => $"'{v}'"))}}}";
        }

        public static string ReverseNoParamReturnVector2()
        {
            Vector2 result = NoParamReturnVector2Callback();
            return $"{{{result.X.ToString("F1")}, {result.Y.ToString("F1")}}}";
        }

        public static string ReverseNoParamReturnVector3()
        {
            Vector3 result = NoParamReturnVector3Callback();
            return $"{{{result.X.ToString("F1")}, {result.Y.ToString("F1")}, {result.Z.ToString("F1")}}}";
        }

        public static string ReverseNoParamReturnVector4()
        {
            Vector4 result = NoParamReturnVector4Callback();
            return $"{{{result.X.ToString("F1")}, {result.Y.ToString("F1")}, {result.Z.ToString("F1")}, {result.W.ToString("F1")}}}";
        }

       public static string ReverseNoParamReturnMatrix4x4()
        {
            // Replace this with the actual callback method and handling.
            var result = NoParamReturnMatrix4x4Callback();

            // Format matrix4x4 as a string
            string formattedRow1 = $"{{{result.M11.ToString("F1")}, {result.M12.ToString("F1")}, {result.M13.ToString("F1")}, {result.M14.ToString("F1")}}}";
            string formattedRow2 = $"{{{result.M21.ToString("F1")}, {result.M22.ToString("F1")}, {result.M23.ToString("F1")}, {result.M24.ToString("F1")}}}";
            string formattedRow3 = $"{{{result.M31.ToString("F1")}, {result.M32.ToString("F1")}, {result.M33.ToString("F1")}, {result.M34.ToString("F1")}}}";
            string formattedRow4 = $"{{{result.M41.ToString("F1")}, {result.M42.ToString("F1")}, {result.M43.ToString("F1")}, {result.M44.ToString("F1")}}}";
            
            return $"{{{formattedRow1}, {formattedRow2}, {formattedRow3}, {formattedRow4}}}";
        }

        public static string ReverseParam1()
        {
            Param1Callback(999);
            return string.Empty;
        }

        public static string ReverseParam2()
        {
            Param2Callback(888, 9.9f);
            return string.Empty;
        }

        public static string ReverseParam3()
        {
            Param3Callback(777, 8.8f, 9.8765);
            return string.Empty;
        }

        public static string ReverseParam4()
        {
            Param4Callback(666, 7.7f, 8.7659, new Vector4(100.1f, 200.2f, 300.3f, 400.4f));
            return string.Empty;
        }

        public static string ReverseParam5()
        {
            Param5Callback(555, 6.6f, 7.6598, new Vector4(-105.1f, -205.2f, -305.3f, -405.4f), new long[]{});
            return string.Empty;
        }

        public static string ReverseParam6()
        {
            Param6Callback(444, 5.5f, 6.5987, new Vector4(110.1f, 210.2f, 310.3f, 410.4f), new long[] { 90000, -100, 20000 }, 'A');
            return string.Empty;
        }

        public static string ReverseParam7()
        {
            Param7Callback(333, 4.4f, 5.9876, new Vector4(-115.1f, -215.2f, -315.3f, -415.4f), new long[] { 800000, 30000, -4000000 }, 'B', "red gold");
            return string.Empty;
        }

        public static string ReverseParam8()
        {
            Param8Callback(222, 3.3f, 1.2345, new Vector4(120.1f, 220.2f, 320.3f, 420.4f), new long[] { 7000000, 5000000, -600000000 }, 'C', "blue ice", 'Z');
            return string.Empty;
        }

        public static string ReverseParam9()
        {
            Param9Callback(111, 2.2f, 5.1234, new Vector4(-125.1f, -225.2f, -325.3f, -425.4f), new long[] { 60000000, -700000000, 80000000000 }, 'D', "pink metal", 'Y', -100);
            return string.Empty;
        }

        public static string ReverseParam10()
        {
            Param10Callback(1234, 1.1f, 4.5123, new Vector4(130.1f, 230.2f, 330.3f, 430.4f), new long[] { 500000000, 90000000000, 1000000000000 }, 'E', "green wood", 'X', -200, (IntPtr)0xabeba);
            return string.Empty;
        }

        public static string ReverseParamRef1()
        {
            int a = default;
            ParamRef1Callback(ref a);
            return $"{a}";
        }

        public static string ReverseParamRef2()
        {
            int a = default;
            float b = default;
            ParamRef2Callback(ref a, ref b);
            return $"{a}|{b.ToString("F1")}";
        }

        public static string ReverseParamRef3()
        {
            int a = default;
            float b = default;
            double c = default;
            ParamRef3Callback(ref a, ref b, ref c);
            return $"{a}|{b.ToString("F1")}|{c}";
        }

        public static string ReverseParamRef4()
        {
            int a = default;
            float b = default;
            double c = default;
            Vector4 d = default;
            ParamRef4Callback(ref a, ref b, ref c, ref d);
            return $"{a}|{b.ToString("F1")}|{c}|{{{d.X.ToString("F1")}, {d.Y.ToString("F1")}, {d.Z.ToString("F1")}, {d.W.ToString("F1")}}}";
        }

        public static string ReverseParamRef5()
        {
            int a = default;
            float b = default;
            double c = default;
            Vector4 d = default;
            long[] e = Array.Empty<long>();
            ParamRef5Callback(ref a, ref b, ref c, ref d, ref e);
            return $"{a}|{b.ToString("F1")}|{c}|{{{d.X.ToString("F1")}, {d.Y.ToString("F1")}, {d.Z.ToString("F1")}, {d.W.ToString("F1")}}}|{{{string.Join(", ", e)}}}";
        }

        public static string ReverseParamRef6()
        {
            int a = default;
            float b = default;
            double c = default;
            Vector4 d = default;
            long[] e = Array.Empty<long>();
            char f =  default;
            ParamRef6Callback(ref a, ref b, ref c, ref d, ref e, ref f);
            return $"{a}|{b.ToString("F1")}|{c}|{{{d.X.ToString("F1")}, {d.Y.ToString("F1")}, {d.Z.ToString("F1")}, {d.W.ToString("F1")}}}|{{{string.Join(", ", e)}}}|{(int)f}";
        }

        public static string ReverseParamRef7()
        {
            int a = default;
            float b = default;
            double c = default;
            Vector4 d = default;
            long[] e = Array.Empty<long>();
            char f =  default;
            string g = "";
            ParamRef7Callback(ref a, ref b, ref c, ref d, ref e, ref f, ref g);
            return $"{a}|{b.ToString("F1")}|{c}|{{{d.X.ToString("F1")}, {d.Y.ToString("F1")}, {d.Z.ToString("F1")}, {d.W.ToString("F1")}}}|{{{string.Join(", ", e)}}}|{(int)f}|{g}";
        }

        public static string ReverseParamRef8()
        {
            int a = default;
            float b = default;
            double c = default;
            Vector4 d = default;
            long[] e = Array.Empty<long>();
            char f =  default;
            string g = "";
            char h =  default;
            ParamRef8Callback(ref a, ref b, ref c, ref d, ref e, ref f, ref g, ref h);
            return $"{a}|{b.ToString("F1")}|{c}|{{{d.X.ToString("F1")}, {d.Y.ToString("F1")}, {d.Z.ToString("F1")}, {d.W.ToString("F1")}}}|{{{string.Join(", ", e)}}}|{(int)f}|{g}|{(int)h}";
        }

        public static string ReverseParamRef9()
        {
            int a = default;
            float b = default;
            double c = default;
            Vector4 d = default;
            long[] e = Array.Empty<long>();
            char f =  default;
            string g = "";
            char h =  default;
            short k = default;
            ParamRef9Callback(ref a, ref b, ref c, ref d, ref e, ref f, ref g, ref h, ref k);
            return $"{a}|{b.ToString("F1")}|{c}|{{{d.X.ToString("F1")}, {d.Y.ToString("F1")}, {d.Z.ToString("F1")}, {d.W.ToString("F1")}}}|{{{string.Join(", ", e)}}}|{(int)f}|{g}|{(int)h}|{k}";
        }

        public static string ReverseParamRef10()
        {
            int a = default;
            float b = default;
            double c = default;
            Vector4 d = default;
            long[] e = Array.Empty<long>();
            char f =  default;
            string g = "";
            char h =  default;
            short k = default;
            IntPtr l = default;
            ParamRef10Callback(ref a, ref b, ref c, ref d, ref e, ref f, ref g, ref h, ref k, ref l);
            return $"{a}|{b.ToString("F1")}|{c}|{{{d.X.ToString("F1")}, {d.Y.ToString("F1")}, {d.Z.ToString("F1")}, {d.W.ToString("F1")}}}|{{{string.Join(", ", e)}}}|{(int)f}|{g}|{(int)h}|{k}|{"0x" + l.ToString("x")}";
        }

        public static string ReverseParamRefVectors()
        {
            // Initialize arrays
            bool[] p1 = Array.Empty<bool>();
            char[] p2 = Array.Empty<char>();
            char[] p3 = Array.Empty<char>();
            sbyte[] p4 = Array.Empty<sbyte>();
            short[] p5 = Array.Empty<short>();
            int[] p6 = Array.Empty<int>();
            long[] p7 = Array.Empty<long>();
            byte[] p8 = Array.Empty<byte>();
            ushort[] p9 = Array.Empty<ushort>();
            uint[] p10 = Array.Empty<uint>();
            ulong[] p11 = Array.Empty<ulong>();
            IntPtr[] p12 = Array.Empty<IntPtr>();
            float[] p13 = Array.Empty<float>();
            double[] p14 = Array.Empty<double>();
            string[] p15 = Array.Empty<string>();

            // Call the method with default values
           ParamRefVectorsCallback(
                ref p1, 
                ref p2, 
                ref p3, 
                ref p4, 
                ref p5, 
                ref p6, 
                ref p7, 
                ref p8, 
                ref p9, 
                ref p10, 
                ref p11, 
                ref p12, 
                ref p13, 
                ref p14, 
                ref p15
            );

            // Format and convert the results
            var p1Formatted = string.Join(", ", p1.Select(v => v.ToString().ToLower()));
            var p2Formatted = string.Join(", ", p2.Select(v => ((int)v).ToString()));
            var p3Formatted = string.Join(", ", p3.Select(v => ((int)v).ToString()));
            var p4Formatted = string.Join(", ", p4.Select(v => v.ToString()));
            var p5Formatted = string.Join(", ", p5.Select(v => v.ToString()));
            var p6Formatted = string.Join(", ", p6.Select(v => v.ToString()));
            var p7Formatted = string.Join(", ", p7.Select(v => v.ToString()));
            var p8Formatted = string.Join(", ", p8.Select(v => v.ToString()));
            var p9Formatted = string.Join(", ", p9.Select(v => v.ToString()));
            var p10Formatted = string.Join(", ", p10.Select(v => v.ToString()));
            var p11Formatted = string.Join(", ", p11.Select(v => v.ToString()));
            var p12Formatted = string.Join(", ", p12.Select(v => "0x" + v.ToString("x")));
            var p13Formatted = string.Join(", ", p13.Select(v => v.ToString("F2")));
            var p14Formatted = string.Join(", ", p14.Select(v => v.ToString()));
            var p15Formatted = string.Join(", ", p15.Select(v => $"'{v}'"));

            return $"{{{p1Formatted}}}|{{{p2Formatted}}}|{{{p3Formatted}}}|{{{p4Formatted}}}|{{{p5Formatted}}}|" +
                   $"{{{p6Formatted}}}|{{{p7Formatted}}}|{{{p8Formatted}}}|{{{p9Formatted}}}|{{{p10Formatted}}}|" +
                   $"{{{p11Formatted}}}|{{{p12Formatted}}}|{{{p13Formatted}}}|{{{p14Formatted}}}|{{{p15Formatted}}}";
        }
        
        public static string ReverseParamAllPrimitives()
        {
            // Call the method and get the result
            var result = ParamAllPrimitivesCallback(
                true, '%', '☢', -1, -1000, -1000000, -1000000000000,
                200, 50000, 3000000000, 9999999999, (IntPtr)0xfedcbaabcdefL,
                0.001f, 987654.456789
            );

            // Return the result as a string
            return $"{result}";
        }
        
         // Define the dictionary mapping strings to methods
        public static readonly Dictionary<string, Func<string>> ReverseTest = new Dictionary<string, Func<string>>
        {
            { "NoParamReturnVoid", ReverseNoParamReturnVoid },
            { "NoParamReturnBool", ReverseNoParamReturnBool },
            { "NoParamReturnChar8", ReverseNoParamReturnChar8 },
            { "NoParamReturnChar16", ReverseNoParamReturnChar16 },
            { "NoParamReturnInt8", ReverseNoParamReturnInt8 },
            { "NoParamReturnInt16", ReverseNoParamReturnInt16 },
            { "NoParamReturnInt32", ReverseNoParamReturnInt32 },
            { "NoParamReturnInt64", ReverseNoParamReturnInt64 },
            { "NoParamReturnUInt8", ReverseNoParamReturnUInt8 },
            { "NoParamReturnUInt16", ReverseNoParamReturnUInt16 },
            { "NoParamReturnUInt32", ReverseNoParamReturnUInt32 },
            { "NoParamReturnUInt64", ReverseNoParamReturnUInt64 },
            { "NoParamReturnPointer", ReverseNoParamReturnPointer },
            { "NoParamReturnFloat", ReverseNoParamReturnFloat },
            { "NoParamReturnDouble", ReverseNoParamReturnDouble },
            { "NoParamReturnFunction", ReverseNoParamReturnFunction },
            { "NoParamReturnString", ReverseNoParamReturnString },
            { "NoParamReturnArrayBool", ReverseNoParamReturnArrayBool },
            { "NoParamReturnArrayChar8", ReverseNoParamReturnArrayChar8 },
            { "NoParamReturnArrayChar16", ReverseNoParamReturnArrayChar16 },
            { "NoParamReturnArrayInt8", ReverseNoParamReturnArrayInt8 },
            { "NoParamReturnArrayInt16", ReverseNoParamReturnArrayInt16 },
            { "NoParamReturnArrayInt32", ReverseNoParamReturnArrayInt32 },
            { "NoParamReturnArrayInt64", ReverseNoParamReturnArrayInt64 },
            { "NoParamReturnArrayUInt8", ReverseNoParamReturnArrayUInt8 },
            { "NoParamReturnArrayUInt16", ReverseNoParamReturnArrayUInt16 },
            { "NoParamReturnArrayUInt32", ReverseNoParamReturnArrayUInt32 },
            { "NoParamReturnArrayUInt64", ReverseNoParamReturnArrayUInt64 },
            { "NoParamReturnArrayPointer", ReverseNoParamReturnArrayPointer },
            { "NoParamReturnArrayFloat", ReverseNoParamReturnArrayFloat },
            { "NoParamReturnArrayDouble", ReverseNoParamReturnArrayDouble },
            { "NoParamReturnArrayString", ReverseNoParamReturnArrayString },
            { "NoParamReturnVector2", ReverseNoParamReturnVector2 },
            { "NoParamReturnVector3", ReverseNoParamReturnVector3 },
            { "NoParamReturnVector4", ReverseNoParamReturnVector4 },
            { "NoParamReturnMatrix4x4", ReverseNoParamReturnMatrix4x4 },
            { "Param1", ReverseParam1 },
            { "Param2", ReverseParam2 },
            { "Param3", ReverseParam3 },
            { "Param4", ReverseParam4 },
            { "Param5", ReverseParam5 },
            { "Param6", ReverseParam6 },
            { "Param7", ReverseParam7 },
            { "Param8", ReverseParam8 },
            { "Param9", ReverseParam9 },
            { "Param10", ReverseParam10 },
            { "ParamRef1", ReverseParamRef1 },
            { "ParamRef2", ReverseParamRef2 },
            { "ParamRef3", ReverseParamRef3 },
            { "ParamRef4", ReverseParamRef4 },
            { "ParamRef5", ReverseParamRef5 },
            { "ParamRef6", ReverseParamRef6 },
            { "ParamRef7", ReverseParamRef7 },
            { "ParamRef8", ReverseParamRef8 },
            { "ParamRef9", ReverseParamRef9 },
            { "ParamRef10", ReverseParamRef10 },
            { "ParamRefArrays", ReverseParamRefVectors },
            { "ParamAllPrimitives", ReverseParamAllPrimitives }
        };
        
    }
}