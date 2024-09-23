//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Sorting
//{
//    public class BubbleSort
//    {
//        public static void Main(string[] args)
//        {
//            int[] arr = { 5, 4, 3, 2, 1 };
//            Sort(arr);
//            foreach(int i in arr)
//            {
//                Console.Write(i + " ");
//            }
            
//        }

//        static void Sort(int[] arr)
//        {
//            for (int i = 0; i < arr.Length; i++)
//            {
//                for (int j = 1; j < arr.Length - i; j++)
//                {
//                    if (arr[j] < arr[j - 1])
//                    {
//                        int temp = arr[j];
//                        arr[j] = arr[j - 1];
//                        arr[j - 1] = temp;
//                    }
//                }
//            }
//        }
//    }
//}
