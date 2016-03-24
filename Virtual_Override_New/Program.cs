using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Override_New
{
    class Father
    {
        public void Say()
        {
            Console.WriteLine("Father is saying");
        }

        public virtual void Talk()
        {
            Console.WriteLine("Father is talking");
        }
    }

    /// <summary>
    /// override 重写之后子类实例的地方无法调用父类的方法
    /// new 新方法 父类对象依旧调用父类方法 
    /// </summary>
    class Son : Father
    {
        public new void Say()
        {
            Console.WriteLine("Son is saying");
        }

        public override void Talk()
        {
            Console.WriteLine("Son is talking");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Son son = new Son();
            son.Say();
            son.Talk();

            Father f = new Son();
            f.Say();
            f.Talk();
            Console.ReadKey();
        }
    }
}
