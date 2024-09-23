//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Generic_Class
//{
//    public class Generic<T>
//    {

//        // private data members
//        private T data;

//        // using properties
//        public T value
//        {

//            // using accessors
//            get
//            {
//                return this.data;
//            }
//            set
//            {
//                this.data = value;
//            }
//        }
//    }

//    // Driver class
//    class Test
//    {

//        // Main method
//        static void Main(string[] args)
//        {

//            // instance of string type
//            Generic<string> name = new Generic<string>();
//            name.value = "Vaibhav";

//            // instance of float type
//            Generic<float> version = new Generic<float>();
//            version.value = 5.0F;

//            // display GeeksforGeeks
//            Console.WriteLine(name.value);

//            // display 5
//            Console.WriteLine(version.value);
//        }
//    }
//}
