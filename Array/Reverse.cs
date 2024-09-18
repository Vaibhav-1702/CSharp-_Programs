//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace Arrays
//{
//    internal class Reverse
//    {
//        static int[] ReverseArr(int[] arr)
//        {
//            int start = 0;
//            int end = arr.Length - 1;

//            while (start < end)
//            {
//                int temp = arr[start];
//                arr[start] = arr[end];
//                arr[end] = temp;
//                start++;
//                end--;
//            }
//            return arr;
//        }
//        static void Main(string[] args)
//        {
//            int[] arr = { 5, 4, 6, 2, 1, 3 };
//            ReverseArr(arr);
//            foreach (int i in arr)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}
