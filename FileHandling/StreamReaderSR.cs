using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    public class StreamReaderSR
    {
        static void Main(String[] args)
        {
            string path = @"F:\myfile.txt";

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    //string line = sr.ReadLine(); // prints only first line
                    // Console.WriteLine(line);



                    string line= sr.ReadToEnd();
                    Console.WriteLine(line);


                    int empty = sr.Peek();
                    Console.WriteLine(empty);


                    //string line = "";
                    //while(( line= sr.ReadLine() )!= null)  // used to print all the present text
                    //{
                    //    Console.WriteLine(line);
                    //}





                    //foreach(var item in sr.ReadLine())  // used to print one char at a time
                    //{
                    //    Console.WriteLine(item);
                    //}


                    //string[] names = new string[5];

                    //for(int i=0;i<names.Length; i++)
                    //{
                    //    names[i] = sr.ReadLine();
                    //}

                    //foreach (string name in names) 
                    //{
                    //    Console.WriteLine(name);
                    //}

                }
            }
        }
    }
}
