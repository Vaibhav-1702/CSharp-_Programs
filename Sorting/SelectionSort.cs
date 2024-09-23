//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Sorting
//{
//    public class SelectionSort
//    {
//        public static void Main(string[] args)
//        {
//            int[] arr = { 6, 4, 3, 2, 1 };
//            SelectionSortAlgorithm(arr);
//            Console.WriteLine(string.Join(", ", arr));
//        }

//        static void SelectionSortAlgorithm(int[] arr)
//        {
//            for (int i = 0; i < arr.Length; i++)
//            {
//                // Find the max item in the remaining array and swap with correct index
//                int last = arr.Length - i - 1;
//                int maxIndex = GetMaxIndex(arr, 0, last);
//                Swap(arr, maxIndex, last);
//            }
//        }

//        static void Swap(int[] arr, int first, int second)
//        {
//            int temp = arr[first];
//            arr[first] = arr[second];
//            arr[second] = temp;
//        }

//        static int GetMaxIndex(int[] arr, int start, int end)
//        {
//            int max = start;
//            for (int i = start; i <= end; i++)
//            {
//                if (arr[max] < arr[i])
//                {
//                    max = i;
//                }
//            }
//            return max;
//        }
//    }
//}
