//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//// https://leetcode.com/problems/rotate-array/
//namespace Arrays
//{
//    internal class RotateArray
//    {
//        static void Main(string[] args)
//        {
//            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
//            int k = 3;
//            Console.WriteLine("Before Rotation ");
            
//            Console.Write("[");
//            foreach (int i in nums)
//            {
//                Console.Write(i + ",");
//            }
//            Console.Write("]");

//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine("After Rotation ");
//            rotate(nums, k);
            
//            Console.Write("[");
//            foreach (int i in nums)
//            {
//                Console.Write(i + ",");
//            }
//            Console.Write("]");


//        }
//        static void rotate(int[] nums, int k)
//        {

//            int n = nums.Length;
//            if (k > n)
//                k = k % n;

//            reverse(nums, 0, n - 1);
//            reverse(nums, 0, k - 1);
//            reverse(nums, k, n - 1);


//        }
//        static int[] reverse(int[] nums, int start, int end)
//        {
//            while (start <= end)
//            {
//                int temp = nums[start];
//                nums[start] = nums[end];
//                nums[end] = temp;
//                start++;
//                end--;
//            }
//            return nums;
//        }

//    }
//}
