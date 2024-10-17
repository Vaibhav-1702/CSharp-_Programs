//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;


//namespace FileHandling
//{
//    public class StreamWriterSW
//    {
//        static void Main(string[] args)
//        {
//            string path = @"F:\myfile.txt";

//            using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
//            {
//                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8)) 
//                {
//                    sw.WriteLine("Hey ");
//                }
//            }

//        }
//    }
//}
