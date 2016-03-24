using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    public class HeapSortClass
    {
        void AdjustHeap(int[] array, int lengh, int current)
        {
            int leftChild = 2 * current + 1;
            int rightChild = leftChild + 1;
            int largest = current;
            int temp;
            while (leftChild < lengh || rightChild < lengh)
            {
                if (leftChild < lengh && array[leftChild] > array[current])
                {
                    largest = leftChild;
                    //temp = array[leftChild];
                    //array[leftChild] = array[current];
                    //array[current] = temp;
                }
                if (rightChild < lengh && array[rightChild] > array[current] && array[rightChild] > array[leftChild])
                {
                    largest = rightChild;
                    //temp = array[rightChild];
                    //array[rightChild] = array[current];
                    //array[current] = temp;
                }
                if (current != largest)
                {
                    temp = array[current];
                    array[current] = array[largest];
                    array[largest] = temp;

                    current = largest;
                    leftChild = 2 * current + 1;
                    rightChild = leftChild + 1;
                }
                else
                    break;

            }
        }

        public void BuildHeap(int[] array, int length)
        {
            int begin = length / 2 - 1;
            for (int i = begin; i >= 0; i--)
            {
                AdjustHeap(array, length, i);
            }
        }


        public void HeapSorting(int[] array, int length)
        {
            int alen = length;
            int temp;
            BuildHeap(array, alen);

            while (alen > 1)
            {
                temp = array[alen - 1];
                array[alen - 1] = array[0];
                array[0] = temp;

                alen--;
                AdjustHeap(array, alen, 0);
            }
        }
    }
}
