using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Polymorphism.Sample2
{
    public interface IA
    {
        void Method();
    }

    public interface IB : IA
    {
        new void Method();
    }

    public class IClass : IB
    {
        public void Method()
        {
            Console.WriteLine("This Method in Class IClass!");
        }
    }

    public class ISubClass : IClass
    {
        public new void Method()
        {
            Console.WriteLine("This Method in Class ISubClass!");
        }
    }
}
