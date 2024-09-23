using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class
{
    public class Generic
    {

        // Generics method
        public void Display<T>(string msg, T value)
        {
            Console.WriteLine("{0}:{1}", msg, value);
        }
    }

    // Driver class
    public class Example
    {

        // Main Method
        public static int Main()
        {

            // creating object of class GFG
            Generic p = new Generic();

            // calling Generics method
            p.Display<int>("Integer", 122);
            p.Display<char>("Character", 'H');
            p.Display<double>("Decimal", 255.67);
            return 0;
        }
    }
}
