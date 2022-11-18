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
        void MethodIA();
    }

    public interface IB : IA
    {
        new void Method();
        void MethodIB();
    }

    public class ImplementClass : IB
    {
        public void Method()
        {
            Console.WriteLine("This Method in Class ImplementClass!");
        }

        public void MethodIA()
        {
            Console.WriteLine("This MethodIA() Method in Class ImplementClass!");
        }

        public void MethodIB()
        {
            Console.WriteLine("This MethodIB() Method in Class ImplementClass!");
        }
    }

    public class ImplementSubClass : ImplementClass
    {
        public new void Method()
        {
            Console.WriteLine("This Method in Class ImplementSubClass!");
        }
    }

    public class ImplementDClass : IA, IB
    {
        public void Method()
        {
            Console.WriteLine("This Method in Class ImplementDClass!");
        }

        public void MethodIA()
        {
            Console.WriteLine("This MethodIA() Method in Class ImplementDClass!");
        }

        public void MethodIB()
        {
            Console.WriteLine("This MethodIB() Method in Class ImplementDClass!");
        }
    }
    public class ImplementSubDClass: ImplementDClass
    {
        public new void Method()
        {
            Console.WriteLine("This Method in Class ImplementSubDClass!");
        }
    }
}
