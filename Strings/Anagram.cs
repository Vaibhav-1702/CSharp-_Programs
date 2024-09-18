using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Anagram
    {
        static void Main(string[] args)
        {
            string str = "dczyxvcucv";
            string str1 = "zyxyavdczg";
            if (anagram(str, str1))
            {
                Console.WriteLine($"String {str} and {str1} are Aanagram");
            }
            else
            {
                Console.WriteLine($"String {str} and {str1} are not Aanagram");
            }
        }

        static Boolean anagram(String str, String str2)
        { 
            if(str.Length != str2.Length)
            {
                return false;
            }
            char[] char1 = str.ToCharArray();
            char[] char2 = str2.ToCharArray();
            Array.Sort(char1);
            Array.Sort(char2);

            for (int i = 0; i < char1.Length; i++)
            { 
                if (char1[i] != char2[i])
                {
                    return false;
                }
            }

            return true;
        }

    }
}
