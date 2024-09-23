using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class CyclicSort
    {
        public static void Main(string[] args)
        {
            int[] arr = { 3, 5, 2, 1, 4 };
            Sort(arr);
            Console.WriteLine(string.Join(", ", arr));
        }

        static void Sort(int[] arr)
        {
            int i = 0;
            while (i < arr.Length)
            {
                int correct = arr[i] - 1;
                if (arr[i] != arr[correct])
                {
                    Swap(arr, i, correct);
                }
                else
                {
                    i++;
                }
            }
        }

        static void Swap(int[] arr, int first, int second)
        {
            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }
    }

}
