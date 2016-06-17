using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace AsyncDelegate
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //
        }

        
        
    }
    class AsyncDelegateClass
    {
        public delegate int TakesAWhileDelegate(int data, int ms);

        public int TakesAWhile(int data, int ms)
        {
            Console.WriteLine("TakesAWhile Started");
            Thread.Sleep(ms);
            Console.WriteLine("TakesAWhile Completed");
            return +data;
        }

        /// <summary>
        /// 投票
        /// </summary>
        void Example1()
        {
            TakesAWhileDelegate d1 = TakesAWhile;
            IAsyncResult ar = d1.BeginInvoke(1, 3000, null, null);
            while (!ar.IsCompleted)
            {
                Console.WriteLine(".");
                Thread.Sleep(50);
            }
            int result = d1.EndInvoke(ar);
            Console.WriteLine("Result is {0}", result);
        }


        /// <summary>
        /// 等待句柄
        /// </summary>
        void Example2()
        {
            TakesAWhileDelegate d1 = TakesAWhile;
            IAsyncResult ar = d1.BeginInvoke(1, 3000, null, null);
            while (true)
            {
                Console.WriteLine(".");
                if (ar.AsyncWaitHandle.WaitOne(50, false))
                {
                    Console.WriteLine("Can not get the result");
                    break;
                }
                int result = d1.EndInvoke(ar);
                Console.WriteLine("Result is {0}", result);
            }
        }


        /// <summary>
        /// 异步回调
        /// </summary>
        void Example3()
        {
            TakesAWhileDelegate d1 = TakesAWhile;
            d1.BeginInvoke(1, 3000, TakesAWhileCompleted, d1);
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(50);
            }
        }
        
        void TakesAWhileCompleted(IAsyncResult ar)
        {
            TakesAWhileDelegate d1 = ar.AsyncState as TakesAWhileDelegate;
            Trace.Assert(d1 != null, "Invalid object type");
            int result = d1.EndInvoke(ar);
            Console.WriteLine("Result is {0}", result);
        }


        void Example4()
        {
            TakesAWhileDelegate d1 = TakesAWhile;
            d1.BeginInvoke(1, 3000, ar =>
            {
                int result = d1.EndInvoke(ar);
                Console.WriteLine("Result is {0}", result);
            }, null);
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(50);
            }
        }
    }
}
