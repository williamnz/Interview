using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Polymorphism.Sample4
{
    class Parent
    {
        //注意事项： 
        //1.重写基方法必须具有与override方法相同的签名。 
        //2.override声明不能更改virtual方法的可访问性，且override方法与virtual方法必须具有相同级别访问修饰符。 
        //3.不能用new、static、virtual修饰符修改override方法。 
        //4.重写属性声明必须指定与继承的属性完全相同的访问修饰符、类型和名称。 
        //5.重写的属性必须是virtual、abstract或override。 
        //6.不能重写非虚方法或静态方法。 
        //7.父类中有abstract，那么子类同名方法必定有override，若父类中有 virtual方法，子类同名方法不一定是override，可能是overload。 
        //8.override必定有父子类关系。
        public void F()
        {
            Console.WriteLine("Parent.F()");
        }
        public virtual void G() //抽象方法
        {
            Console.WriteLine("Parent.G()");
        }

        //二、overload重载，在同一个类中方法名相同、参数或返回值不同的多个方法即为方法重载。 
        //注意事项： 
        //1.出现在同一个类中。 
        //2.参数列表不同或返回类型和参数列表都不同，只有返回类型不同不能重载。(参数列表包括参数个数和参数类型)
        public int Add(int x, int y)
        {
            return x + y;
        }
        public float Add(float x, float y) //重载(overload)Add函数
        {
            return x + y;
        }
    }
    class ChildOne : Parent //子类一继承父类
    {
        //三、overwrite覆写，用new实现。在子类中用 new 关键字修饰定义的与父类中同名的方法，也称为覆盖，覆盖不会改变父类方法的功能。
        public new void F() //重写(overwrite)父类函数
        {
            Console.WriteLine("ChildOne.F()");
        }
        public override void G() //覆写(override)父类虚函数,主要实现多态
        {
            Console.WriteLine("ChildOne.G()");
        }
    }
    class ChildTwo : Parent //子类二继承父类
    {
        new public void F()
        {
            Console.WriteLine("ChildTwo.F()");
        }
        public override void G()
        {
            Console.WriteLine("ChildTwo.G()");
        }
    }
    
}
