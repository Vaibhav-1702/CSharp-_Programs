//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////https://leetcode.com/problems/two-sum/description/
//namespace Arrays
//{
//    internal class TwoSum
//    {
//        static int[] twoSum(int[] nums, int target)
//        {
//            for (int i = 0; i < nums.Length; i++)
//            {
//                for (int j = i + 1; j < nums.Length; j++)
//                {
//                    if (nums[i] + nums[j] == target)
//                    {
//                        return new int[] { i, j };
//                    }
//                }
//            }

//            return new int[] { 0, 0 };
//        }

//        static void Main(string[] args)
//        {
//            int[] nums = { 3, 7, 11, 15 };
//            int target = 22;

//            int []newArr = twoSum(nums,target);
//            Console.Write("[");
//            foreach (int i in newArr)
//            {
//                Console.Write(i+",");
//            }
//            Console.Write("]");

//        }
//    }
//}
