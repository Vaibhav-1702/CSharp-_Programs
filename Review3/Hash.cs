using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review3
{
    public class Hash
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();
            names.Add("Vaibhav");
            names.Add("Sujal");
            names.Add("Raj");

            Console.WriteLine("Set1");
            foreach (string name in names) 
            {
                Console.WriteLine(name);
            }


            HashSet<string> names1= new HashSet<string>();

            names1.Add("Vaibhav");
            names1.Add("Sujal");
            names1.Add("Raj");
            names1.Add("Aditya");
            names1.Add("Aniket");


            Console.WriteLine("");
            Console.WriteLine("Set2");
            foreach (string name in names1)
            {
                Console.WriteLine(name);
            }

            //Console.WriteLine("");

            //names.UnionWith(names1);
            //Console.WriteLine("Union");
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}


            //Console.WriteLine("");

            //names.IntersectWith(names1);
            //Console.WriteLine("Intersect");
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}


            Console.WriteLine("");

            names1.ExceptWith(names);
            Console.WriteLine("Expect");
            foreach (string name in names1)
            {
                Console.WriteLine(name);
            }



        }
    }
}
