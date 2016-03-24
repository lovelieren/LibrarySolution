using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateInvoke
{
    class PrintClass
    {
        public delegate void PrintHandler();

        public PrintHandler handler;

        public event PrintHandler pHandler;
        internal void PrintName()
        {
            Console.WriteLine("My name is Jackie");
        }

        internal void PrintIntroduce()
        {
            Console.WriteLine("I'm a programmer");
        }

        internal void EventInvoke()
        {
            pHandler();
        }
    }
    class Program    
    {
        

        void InitialEvent()
        {
            PrintClass pc = new PrintClass();

            pc.handler = pc.PrintName;
            pc.handler += pc.PrintIntroduce;
            pc.handler();

            pc.pHandler += pc.PrintName;
            pc.pHandler += pc.PrintIntroduce;
            pc.EventInvoke();
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.InitialEvent();
            Console.ReadKey();
        }

    }
}
