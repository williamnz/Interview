using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Other
{
    public class LearnDelegate
    {
        private int result;

        private int AddNumbers(int param1, int param2)
        {
            return param1 + param2;
        }

        public void FuncTest()
        {
            //use function
            Func<int, int, int> Addition = AddNumbers;
            int result = AddNumbers(10, 20);
            Console.WriteLine($"Func Addition: 10 + 20 = {result}");

            //use anonymous method
            Func<int, int, int> Addition1 = delegate (int param1, int param2)
            {
                return param1 + param2;
            };
            int result1 = Addition1(11, 21);
            Console.WriteLine($"Func Addition: 11 + 21 = {result1}");

            //use lambda expression            
            Func<int, int, int> Addition2 = (param1, param2) => param1 + param2;
            //Func<int, int, int> Addition2 = (param1, param2) => param1 + param2;
            //Func<int, int, int> Addition2 = (param1, param2) => { return param1 + param2; };
            int result2 = Addition2(9, 8);
            Console.WriteLine($"Func Addition: 9 + 8 = {result2}");
        }

        private void ActionAddNumbers(int param1, int param2)
        {
            result =  param1 + param2;
        }

        public void ActionTest()
        {
            //Use function
            Action<int, int> Addition1 = ActionAddNumbers;
            Addition1(10, 20);
            Console.WriteLine($"Action Addition: 10 + 20 = {result}");
            //Use anonymous method
            Action<int, int> Addition2 = delegate (int param1, int param2)
            {
                result = param1 + param2;
            };
            Addition2(11, 21);
            Console.WriteLine($"Action Addition: 11 + 21 = {result}");
            //Use lambda expression            
            Action<int, int> Addition3 = (param1, param2) => result = param1 + param2; ;
            //Action<int, int> Addition3 = (param1, param2) =>
            //{
            //    result = param1 + param2;
            //};
            Addition3(9, 8);
            Console.WriteLine($"Action Addition: 9 + 8 = {result}");
        }

        private bool IsApple(string modelName)
        {
            if (modelName == "Iphone X")
                return true;
            else
                return false;
        }

        public void PredictTest()
        {
            //Use Function
            Predicate<string> CheckIfApple = IsApple;
            bool result1 = IsApple("Iphone X");
            if (result1)
                Console.WriteLine("It's an iphone");
            //Use anonymous
            Predicate<string> CheckIfApple2 = delegate (string modelName)
            {
                if (modelName == "Iphone X") return true;
                else return false;
            };
            bool result2 = CheckIfApple2("Iphone X");
            if (result2)
                Console.WriteLine("It's an iphone");
            //Use lambda
            Predicate<string> CheckIfApple3 = modelName =>
            {
                if (modelName == "Iphone X") return true;
                else return false;
            };
            bool result3 = CheckIfApple3("Iphone X");
            if (result3)
                Console.WriteLine("It's an iphone");
        }
    }
}
