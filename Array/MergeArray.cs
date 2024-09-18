//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Arrays
//{
//    internal class MergeArray
//    {
//        static void Main(String[] args)
//        {
//            int[] arr1 = { 1, 3, 5, 7 };
//            int[] arr2 = { 2, 4, 6, 8 }; 
//            int[] arr3 = new int[arr1.Length + arr2.Length];

//            mergeArrays(arr1, arr2, arr3);

//            foreach (int value in arr3)
//            {
//                Console.Write(value + " ");
//            }
//        }

//        static void mergeArrays(int[] arr1, int[] arr2, int[] arr3)
//        {
//            int n1 = arr1.Length;
//            int n2 = arr2.Length;
//            int i = 0, j = 0, k = 0;

//            // Traverse arr1 and insert its elements into arr3
//            while (i < n1)
//            {
//                arr3[k] = arr1[i];
//                k++;
//                i++;
//            }

//            // Traverse arr2 and insert its elements into arr3
//            while (j < n2)
//            {
//                arr3[k] = arr2[j];
//                j++;
//                k++;
//            }

//            // Sort the entire arr3
//            Array.Sort(arr3);
//        }
//    }
//}
