using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACA_Homework.Assingment_3
{
    public class HeapSort : Algorithm
    {
        public override string Sort(int[] randomArray)
        {
            int n = randomArray.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(randomArray, n, i);

            for (int i = n - 1; i >= 0; i--)
            {
                int temp = randomArray[0];
                randomArray[0] = randomArray[i];
                randomArray[i] = temp;
                Heapify(randomArray, i, 0);
            }

            return Convert.ToString(randomArray);
        }
        static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
                largest = left;

            if (right < n && arr[right] > arr[largest])
                largest = right;

            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                Heapify(arr, n, largest);
            }
        }
    }
}
