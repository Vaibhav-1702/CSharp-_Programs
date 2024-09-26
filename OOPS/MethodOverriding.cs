//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    class Animal
//    {
//        // Virtual method in base class
//        public virtual void Speak()
//        {
//            Console.WriteLine("The animal makes a sound.");
//        }
//    }

//    class Dog : Animal
//    {
//        // Overriding the base class method
//        public override void Speak()
//        {
//            Console.WriteLine("The dog barks.");
//        }
//    }

//    class Cat : Animal
//    {
//        // Overriding the base class method
//        public override void Speak()
//        {
//            Console.WriteLine("The cat meows.");
//        }
//    }

//    class MethodOverriding
//    {
//        static void Main()
//        {
//            Animal myAnimal = new Animal(); // Base class reference
//            Animal myDog = new Dog();       // Base class reference, Dog object
//            Animal myCat = new Cat();       // Base class reference, Cat object

//            myAnimal.Speak();   // Output: The animal makes a sound.
//            myDog.Speak();      // Output: The dog barks.
//            myCat.Speak();      // Output: The cat meows.
//        }
//    }
//}
