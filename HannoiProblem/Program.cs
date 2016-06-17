using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HannoiProblem
{
    /// <summary>
    /// 递归方式求解汉诺塔问题
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Hannoi hanoi = new Hannoi();
            hanoi.HannoiRecursion(5, 1, 2, 3);
            Console.ReadKey();
        }
    }

    class Hannoi
    {
        public void HannoiRecursion(int n, int first, int second, int third)
        {
            if (n > 0)
            {
                HannoiRecursion(n - 1, first, third, second);
                Console.WriteLine("{0}->{1}", first, third);
                HannoiRecursion(n - 1, second, first, third);
            }
        }
        private int i = 0;

        public int I
        {
            get { return i; }
            set { i = value; }
        }
    }
}
