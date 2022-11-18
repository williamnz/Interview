using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Sort
{
    public class SortHelper
    {
        public static int[] GenerateRandomArray(int num, int minValue, int maxValue)
        {
            Stopwatch sw = new Stopwatch();
            int[] arr = new int[num];

            for (int i = 0; i < arr.Length; i++)
            {
                sw.Start();
                sw.Stop();
                arr[i] = new Random((int)sw.ElapsedTicks).Next(minValue, maxValue);                
            }
            return arr;
        }

        public static int GenerateRandonNumber(int minValue, int maxValue)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            sw.Stop();
            return new Random((int)sw.ElapsedTicks).Next(minValue, maxValue);
        }
    }
}
