using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Polymorphism.Sample5
{
    /// <summary>
    /// 用来声明接口：只提供一些方法规约，不提供方法主体
    /// 方法不能用public，abstract等修饰,无字段变量，无构造函数
    /// </summary>
    public interface IPerson
    {
        void GetName();//不包含方法主体
        void GetAge(string s);
    }
    public class Chinese : IPerson
    {
        public Chinese() { } //添加构造
        public void GetName() { } //实现getName()
        public void GetAge(string s) { } //实现getAge()
    }
    /// <summary>
    /// abstract:声明抽象类、抽象方法
    /// 1.抽象方法所在类必须为抽象类
    /// 2.抽象类不能直接实例化，必须由其派生类实现。
    /// 3.抽象方法不包含方法主体，必须由派生类以override方式实现此方法,这点跟interface中的方法类似
    /// </summary>
    public abstract class Book
    {
        public Book()
        {
        }
        public abstract void GetPrice(); //抽象方法，不含主体
        public virtual void GetName() //虚方法，可覆盖
        {
            Console.WriteLine("this is a test:virtual getName()");
        }
        public virtual void GetContent() //虚方法，可覆盖
        {
            Console.WriteLine("this is a test:virtual getContent()");
        }
        public void GetDate() //一般方法，若在派生类中重写，须使用new关键字
        {
            Console.WriteLine("this is a test: void getDate()");
        }
    }

    public class JavaBook : Book
    {
        public override void GetPrice() //实现抽象方法，必须实现
        {
            Console.WriteLine("this is a test:JavaBook override abstract getPrice()");
        }
        public override void GetName() //覆盖原方法，不是必须的
        {
            Console.WriteLine("this is a test:JavaBook override virtual getName()");
        }
        public new void GetDate()
        {
            Console.WriteLine("this is a test:JavaBook new GetDate()");
        }
    }

    public class CBook : Book, IPerson
    {
        public void GetAge(string s)
        {
            Console.WriteLine("this is a test:CBook new GetAge()");
        }
        public override void GetPrice()
        {
            Console.WriteLine("this is a test:CBook new GetPrice()");
        }
    }

    public class Test1
    {
        public Test1()
        {
            Book jbook = new JavaBook();
            jbook.GetPrice(); //将调用JavaBook中GetPrice()
            jbook.GetName(); //将调用JavaBook中GetName()
            jbook.GetContent(); //将调用Abstract Book中GetContent()
            jbook.GetDate(); //将调用Abstract Book中GetDate()


            IPerson p = new CBook();
            p.GetName();
        }
    }
}