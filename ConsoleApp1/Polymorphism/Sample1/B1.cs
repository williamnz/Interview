using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Polymorphism.Sample1
{
    public class B1 : A
    {
        public new void Method()
        {
            Console.WriteLine("This Method in Class B!");
        }
    }
}
