using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[9] { 6, 4, 3, 7, 5, 2, 9, 1, 8 };
            Console.WriteLine("排序前:");
            foreach (int i in array)
            {
                Console.Write(i.ToString()+" ");
            }
            HeapSortClass _heapSort = new HeapSortClass();
            _heapSort.HeapSorting(array, array.Length);
            Console.WriteLine("\n排序后:");
            foreach (int i in array)
            {
                Console.Write(i.ToString()+" ");
            }
            Console.ReadKey();
        }
    }
}
