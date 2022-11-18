using ConsoleApp1.Heap;
using ConsoleApp1.Polymorphism.Sample1;
using ConsoleApp1.Tree;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //TreeTest1();

            //new: 假如运行A a = new B();a.Method();会输出This Method in Class A!,
            //这是因为class B继承于class A，现在B中的Method函数隐藏A中的Method，
            //所以从B(包括继承于B的子类)的角度来看类中的Method就是B.Method，A的Method不可见，
            //但是如果从A的角度来看B，A只认识类B中继承于类A的Method函数,对于B类中的Method它不可见，
            //所以A a = new B();a.Method();相当于是调用了类B中继承于A的Method函数
            A a = new B1();
            a.Method();
            B1 b = new B1();
            b.Method();

            //override:假如运行A a = new B();a.Method();会输出This Method in Class B!,
            //因为class B的Method函数完全覆盖基类的同名虚函数Method，使整个继承链中看见
            //的Method函数都是B中的Method，所以就算是以A角度来看B，A看到的Method函数也是B中的Method，因为A中的Method完全被B的覆盖了
            A a2 = new B2();
            a2.Method();
            B2 b2 = new B2();
            b2.Method();

            //new、override与interface
            //接口在相互继承的时候也会隐藏基接口的同名属性或函数，但是对于接口来说很特殊，隐藏对于基接口来说是不起作用的，
            //接口内部的属性和函数都只是声明，它们都指向实现接口的类中的同名实现函数，通过接口调用接口的属性和函数的时候都会去调用实现类中从上到下最先可见的同名函数和同名属性:
            //Sample2
            Polymorphism.Sample2.IA ia = new Polymorphism.Sample2.ImplementSubClass();
            ia.Method();
            ia.MethodIA();

            Polymorphism.Sample2.IB ib = new Polymorphism.Sample2.ImplementSubClass();
            ib.Method();
            ib.MethodIA();

            Polymorphism.Sample2.ImplementSubClass isub = new Polymorphism.Sample2.ImplementSubClass();
            isub.Method();
            isub.MethodIA();
            isub.MethodIB();

            Polymorphism.Sample2.ImplementClass mainClass = new Polymorphism.Sample2.ImplementSubClass();
            mainClass.Method();

            Polymorphism.Sample2.IA ia_1 = new Polymorphism.Sample2.ImplementSubDClass();
            ia_1.Method();

            //因为父Class中Method是Virtual虚方法，当申明子类实列时，执行子类中方法
            Polymorphism.Sample3.IA ia2 = new Polymorphism.Sample3.ISubClass();
            ia2.Method();
            //因为父Class中Method是Virtual虚方法，当申明父类实列时，执行父类中方法
            Polymorphism.Sample3.IA ia2_1 = new Polymorphism.Sample3.IClass();
            ia2_1.Method();

            //
            Polymorphism.Sample4.Parent childOne = new Polymorphism.Sample4.ChildOne();
            Polymorphism.Sample4.Parent childTwo = new Polymorphism.Sample4.ChildTwo();
            //调用Parent.F()
            childOne.F();
            childTwo.F();
            //实现多态
            childOne.G();
            childTwo.G();

            //重载案列
            Polymorphism.Sample4.Parent load = new Polymorphism.Sample4.Parent();
            //重载(overload)
            Console.WriteLine(load.Add(1, 2));
            Console.WriteLine(load.Add(3.4f, 4.5f));

            //抽象类不能实列化(如Book)
            Polymorphism.Sample5.Test1 test1 = new Polymorphism.Sample5.Test1();

            Polymorphism.Sample5.Test test2 = new Polymorphism.Sample5.Test("HP");

            //HeapShiftUpTest();
            Console.Read();


        }
        public static void TreeTest1()
        {
            var tree = new BinarySearchTree();
            int t = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                tree.InsertNodeItem(int.Parse(arr[i]));
            }
            //tree.Preorder(tree.root);
            int height = tree.GetHeight(tree.root);
            Console.WriteLine(height);
        }
        public static void HeapShiftUpTest()
        {
            Stopwatch sw = new Stopwatch();
            HeapShiftUp<int> heapShiftUp = new HeapShiftUp<int>(10);
            int N = 10;//堆中元素个数
            int M = 100;//堆中元素取值范围[0, M)
            
            for (int i = 0; i < N; i++)
            {
                sw.Start();
                sw.Stop();
                int random = new Random((int)sw.ElapsedTicks).Next(0, M);
                Console.Write(random + " ");
                heapShiftUp.Insert(random);
            }
            Console.WriteLine();
            for (int i = 0; i < N+1; i++)
            {
                Console.Write(heapShiftUp.Data[i] + " ");
            }
        }

        public static void HeapShiftDownTest()
        {

        }

        //2 dimensional string arrays A and B
        //A:
        //a b c
        //d e f
        //g h i


        //B:
        //a g d
        //g m n
        //c d e


        //Result of Full Outer Join on first column
        //a b c a g d
        //d e f - - -
        //- - - c d e
        //g h i g m n




        public static string[,] FullOuterJoin(string[][] A, string[][] B)
        {
            //from a in A
            //join b in B
            //on a equals b into g
            //from b in g.DefaultIfEmpty()
            //select new 

            string[,] a = new string[3, 3]
            {
                {"a","b","c" },
                {"a","b","c" },
                {"a","b","c" }
            };

            string [,] c = new string[7, 7] {
             {" ","■","■","■","■","■"," "},
             {" "," "," ","■"," "," "," "},
             {" "," "," ","■"," "," "," "},
             {" "," ","■","■","■"," "," "},
             {" "," "," ","■"," "," "," "},
             {" "," "," ","■"," "," "," "},
             {"■","■","■","■","■","■","■"}
            };
            return c;
        }
    }
}
