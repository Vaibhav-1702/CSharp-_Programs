
//using System.Text.RegularExpressions;

//string pattern = @"^\+91\s[6-9]{1}[0-9]{9}$";

//Console.WriteLine(Regex.IsMatch("+91 8669516722",pattern));
//Console.WriteLine(Regex.IsMatch("+91 7789542557", pattern));
//Console.WriteLine(Regex.IsMatch("+91 8688958858", pattern));
//using System;
//using System.Text.RegularExpressions;

//namespace Regular_Expression
//{
//    class MobileNo 
//    {
//        static void Main()
//        {
//            string pattern = @"^\+91\s[6-9]{1}[0-9]{9}$";
//            Regex regex = new Regex(pattern);
            

//            string[] noPattern = { "+91 7894561234", "+91 6234567890", "+91 5678901234", "+91 8123456789" };

//            foreach (string s in noPattern)
//            {
//                if (regex.IsMatch(s))
//                {
//                    Console.WriteLine($"{s} is a valid no ");
//                }
//                else
//                {
//                    Console.WriteLine($"{s} is not a valid no ");
//                }
//            }

//        }
//    }
//}



