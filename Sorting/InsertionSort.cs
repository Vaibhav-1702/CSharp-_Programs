//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Sorting
//{
//    public class InsertionSort
//    {
//        public static void Main(string[] args)
//        {
//            int[] arr = { 5, 4, 3, 2, 1 };
//            Insert(arr);
//            Console.WriteLine(string.Join(", ", arr));
//        }

//        static void Insert(int[] arr)
//        {
//            for (int i = 0; i < arr.Length - 1; i++)
//            {
//                for (int j = i + 1; j > 0; j--)
//                {
//                    if (arr[j] < arr[j - 1])
//                    {
//                        int temp = arr[j];
//                        arr[j] = arr[j - 1];
//                        arr[j - 1] = temp;
//                    }
//                    else
//                    {
//                        break;
//                    }
//                }
//            }
//        }
//    }

//}
