using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public static class ArrHelper
    {
        public static int[] isValid(int[][] arr)
        {
            if (arr.Length != 3) return [-1];
            if (arr[0].Length != 3 || arr[1].Length != 3 || arr[2].Length != 3) return [-1];

            int a = arr[0][0];
            int b = arr[0][2];
            int c = arr[2][0];
            int d = arr[2][2];

            if (a + b != arr[0][1]) return [-1];
            if (b + d != arr[1][2]) return [-1];
            if (c + d != arr[2][1]) return [-1];
            if (a + c != arr[1][0]) return [-1];
            if (a + b + c + d != arr[1][1]) return [-1];

            return [a, b, c, d];

        }
    }
}
