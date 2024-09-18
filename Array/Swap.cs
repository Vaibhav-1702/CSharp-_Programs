using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Swap
    {
        static void Main(string[] args)
        {
            int[] arr = {11,12,1,3,5,7,8,9,16,6};
            int minNo = arr[0];
            int minInd =0;
            int maxNo = arr[0];
            int maxInd =0;

            // Finding Minimum No and Index
            for (int i = 0; i < arr.Length; i++)
            {
                if (minNo > arr[i])
                {
                    minNo = arr[i];
                    minInd = i;
                }
             }

            // Finding Maximum No and Index
            for (int i = 0; i < arr.Length; i++)
            {
                if (maxNo < arr[i])
                {
                    maxNo = arr[i];
                    maxInd = i;
                }
            }
            
            Console.WriteLine("Before Swapping ");

            Console.Write("[");
            foreach (int i in arr)
            {
                Console.Write(i + ",");
            }
            Console.Write("]");

            Console.WriteLine();
            Console.WriteLine();

            // Calling Swap Method To swap maximum and minimum
            swap(arr, minInd, maxInd);

            Console.WriteLine("After Swapping ");
            Console.Write("[");
            foreach (int i in arr)
            {
                Console.Write(i + ",");
            }
            Console.Write("]");
            Console.WriteLine();
            Console.WriteLine($"Swapped No are {minNo} and {maxNo}");

        }

        static void swap(int[] arr, int min, int max)
        {
            int temp = arr[min];
            arr[min] = arr[max];
            arr[max] = temp;
        }
    }
}
