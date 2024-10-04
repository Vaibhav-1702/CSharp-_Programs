//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace Regular_Expression
//{
//    public class CapName
//    {
//        static void Main(string[] args)
//        {
//             string pattern1 = @"^[A-Z][a-z]*$";

//            string[] names = { "John", "james", "Alice", "ALICE", "alice", "Bobby", "boB" };

//            Regex regex = new Regex(pattern1);

//            foreach (string s in names)
//            {
//                if (regex.IsMatch(s))
//                {
//                    Console.WriteLine($"{s} is a valid name ");
//                }
//                else
//                {
//                    Console.WriteLine($"{s} is not a valid name ");
//                }
//            }
//        }


//    }
//}
