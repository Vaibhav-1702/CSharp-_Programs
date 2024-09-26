//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    class Car
//    {
//        public string brand;
//        public string model;

//        // Default Constructor
//        public Car()
//        {
//            brand = "Unknown";
//            model = "Unknown";
//        }

//        // Parameterized Constructor
//        public Car(string b, string m)
//        {
//            brand = b;
//            model = m;
//        }

//        // Copy Constructor
//        public Car(Car car)
//        {
//            brand = car.brand;
//            model = car.model;
//        }


//        public void DisplayInfo()
//        {
//            Console.WriteLine($"Brand: {brand}, Model: {model}");
//        }
//    }

//    public  class Constructors
//    {
//        static void Main()
//        {
//            Car car1 = new Car(); // Default constructor is called
//            Car car2 = new Car("Audi","Q7");
//            Car car3 = new Car(car1);
//            car1.DisplayInfo(); 
//            car2.DisplayInfo();
//            car3.DisplayInfo();
//        }
//    }
//}
