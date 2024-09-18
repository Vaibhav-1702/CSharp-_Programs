//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Strings
//{
//    internal class ReverseStr
//    {
//        static void Main(string[] args)
//        {
//            string str1 = "ABCDEF";
            
//           // Console.WriteLine(str2);
//            Console.WriteLine(Reverse2(str1));


//        }

//        static string Reverse1(string str)
//        {
//            string str2 = "";
//            for (int i = 0; i < str.Length; i++)
//            {
//                str2 = str[i] + str2;
//            }
//            return str2;
//        }

//        static string Reverse2(string str)
//        {   
//            char[] chars = str.ToCharArray();
//            int start = 0;
//            int end = str.Length-1;
//            while (start < end)
//            {
//                char temp = chars[start];   
//                chars[start] = chars[end];
//                chars[end] = temp;
//                start++;
//                end--;
//            }
//            string str2= new string(chars);

//            return str2;
//        }

//    }
//}
