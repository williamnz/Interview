using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.Other
{
    internal class LearnYield
    {
        public IEnumerable<int> GetOddNumber_0(int start, int end)
        {
            List<int> list = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 1)
                    list.Add(i);
            }
            return list;
        }

        public IEnumerable<int> GetOddNumber(int start, int end)
        {
            for (int i = start; i <= end; i++)
                if (i % 2 == 1)
                    yield return i;
        }

        public IEnumerable<int> GetNumberOnCondition(Func<int, bool> condition, int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (condition(i))
                    yield return i;
            }
        }

        public bool IsPrime(int number)
        {
            if (number == 1) return false; 
            if (number == 2) return true; 
            if (number % 2 == 0) return false; 
            //Even number
            long nn= (long) Math.Abs(Math.Sqrt(number)); 
            for (long i = 3; i < nn; i += 2) 
            { 
                if (number % i == 0) 
                    return false; 
            } 
            return true; 
        }
        public void Test0()
        {
            foreach (int num in GetOddNumber_0(20, 30))
            {
                if (IsPrime(num)) // IsPrim(int) 函数用于判断一个int是不是素数，代码略。
                {
                    Console.WriteLine(num);
                }
            }
        }

        public void Test1()
        {
            foreach (int num in GetOddNumber(20, 30))
            {
                if (IsPrime(num)) // IsPrim(int) 函数用于判断一个int是不是素数，代码略。
                {
                    Console.WriteLine(num);
                    break;
                }
            }
        }

        public void Test2()
        {
            foreach (int num in GetNumberOnCondition(n => IsPrime(n), 20, 30))
                Console.WriteLine(num);
        }
    }
}
