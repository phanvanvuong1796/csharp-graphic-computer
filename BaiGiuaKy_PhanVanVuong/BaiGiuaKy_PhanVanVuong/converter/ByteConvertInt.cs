using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiGiuaKy_PhanVanVuong.converter
{
    public class ByteConvertInt
    {
        public static int byte4Int(byte[] arr, int index)
        {
            int result = (int)(arr[index] + arr[index + 1] * Math.Pow(2, 8) 
                                            + arr[index + 2] * Math.Pow(2, 16) 
                                            + arr[index + 3] * Math.Pow(2, 24));
            return result;
        }

        public static int byte2Int(byte[] arr, int index)
        {
            int result = (int)(arr[index] + arr[index+1] * Math.Pow(2, 8));
            return result;
        }

        public static long byte4Long(byte[] arr, int index)
        {
            long result = (long)(arr[index] + arr[index + 1] * Math.Pow(2, 8)
                                            + arr[index + 2] * Math.Pow(2, 16)
                                            + arr[index + 3] * Math.Pow(2, 24));
            return result;
        }

        public static uint byte4Uint(byte[] arr, int index)
        {
            uint result = (uint)(arr[index] + arr[index+1] * Math.Pow(2, 8)
                                            + arr[index + 2] * Math.Pow(2, 16)
                                            + arr[index + 3] * Math.Pow(2, 24));
            return result;
        }
    }
}
