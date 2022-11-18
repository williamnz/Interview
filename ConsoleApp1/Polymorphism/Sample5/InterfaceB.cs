using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Polymorphism.Sample5
{
    //打印机接口
    public interface IPrint
    {
        string ReturnPrintName();
    }
    //HP牌打印机类
    public class HP : IPrint
    {
        public string ReturnPrintName()
        {
            return "这是HP牌打印机";
        }
    }
    //Eps牌打印机类
    public class Eps : IPrint
    {
        public string ReturnPrintName()
        {
            return "这是Eps牌打印机";
        }
    }
    //打印类
    public class Printer
    {
        public Printer() { }
        public string PrintName(IPrint iPrint)
        {
            return iPrint.ReturnPrintName();
        }           
    }

    public class Test
    {
        public Test(string name)
        {
            Printer p = new Printer();
            switch (name)
            {
                case "HP":
                    Console.Write(p.PrintName(new HP()));
                    break;
                case "Eps":
                    Console.Write(p.PrintName(new Eps()));
                    break;
                default:
                    Console.Write("没有发现这个品牌！");
                    break;
            }
        }
    }
}
