using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultipleParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            Console.WriteLine(cal.Add(1, 2, 3, 4, 5).ToString());
            Console.ReadKey();
        }

        private class Calculator
        {
            public double Add(params double[] array)
            {
                double sum = 0;
                foreach (double d in array)
                {
                    sum += d;
                }
                return sum;
            }
        }
    }
}
