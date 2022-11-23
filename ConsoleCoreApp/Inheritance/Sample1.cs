using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.Inheritance
{
    class Person1
    {
        public Person1()
        {
            Console.WriteLine("Called the Person1's constructor");
        }
    }
    class Employee1 : Person1
    {
        public Employee1()
        {
            Console.WriteLine("Called the Employee1's constructor");
        }
    }

    class Person2
    {
        public Person2()
        {
            Console.WriteLine("Called the Person2's constructor");
        }

        public Person2(string name)
        {
            Console.WriteLine("Called the Person2's constructor with a parameter");
        }
    }

    class Employee2 : Person2
    {
        public Employee2()
        {
            Console.WriteLine("Called the Employee2's constructor");
        }

        public Employee2(string name)
        {
            Console.WriteLine("Called the Employee2's constructor with a parameter");
        }
    }

    class Person3
    {
        public Person3(string name)
        {
            Console.WriteLine("Called the Person3's constructor with a parameter");
        }
    }

    class Employee3 : Person3
    {
        public Employee3(string name) : base(name)
        {
            Console.WriteLine("Called the Employee3's constructor with a parameter");
        }
    }
}
