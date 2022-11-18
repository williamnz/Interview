using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Polymorphism.Sample3
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
        public virtual void Method()
        {
            Console.WriteLine("This Method in Class IClass!");
        }
    }

    public class ISubClass : IClass
    {
        public override void Method()
        {
            Console.WriteLine("This Method in Class ISubClass!");
        }
    }
}
