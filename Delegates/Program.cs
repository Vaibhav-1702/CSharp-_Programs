//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Serialization;

//namespace Delegates
//{
//    public delegate void AddDelegate(int a, int b);
//    class Program
//    {
//        public void AddNum(int num1, int num2)
//        {
//            Console.WriteLine(num1+num2);
//        }
//        static void Main(string[] args)
//        {
//            Program p = new Program();
//            AddDelegate ad = new AddDelegate(p.AddNum);
//            ad.Invoke(10, 20);
//            ad(10, 40);
             
            
//        }
//    }
//}