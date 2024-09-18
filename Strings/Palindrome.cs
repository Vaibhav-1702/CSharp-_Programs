//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Strings
//{
//    internal class Palindrome
//    {
//        static void Main(string[] args)
//        {
//            string str1 = "ab";

//            if (palin(str1))
//            {
//                Console.WriteLine($"String {str1} is palindrome");
//            }
//            else
//            {
//                Console.WriteLine($"String {str1} is not palindrome");
//            }
//        }

//        static Boolean palin(string str)
//        {  
//            if (str.Length == 0 || str.Length == 1)
//            {
//                return true;
//            }

//            char[] chars = str.ToCharArray();
//            int start = 0;
//            int end = str.Length - 1;

//            while (start < end)
//            {
//                char temp = chars[start];
//                chars[start] = chars[end];
//                chars[end] = temp;
//                start++;
//                end--;
//            }

//            string str2 = new string(chars);

//            if (str == str2)
//            { 
//                return true;
//            }
//            return false;
//        }
//    }
//}
