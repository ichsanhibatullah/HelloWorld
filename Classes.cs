using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    //internal class Classes
    //{
    //}

    // OOP
    class Car
    {
        public string color = "red";

        static void CarMethod()
        {
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);
        }
    }

    // Class Members
    class MyClass
    {
        // Class members: two fields and one method
        string color = "red";        // field
        int maxSpeed = 200;          // field
        public void fullThrottle()   // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }

    class Car2
    {
        /* You can also leave the fields blank, and modify them when creating the object
        This is especially useful when creating multiple objects of one class */

        public string model;               // field
        public string color;               // field
        public int year;                   // field
        public void fullThrottle()         // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
        /*public void templateCars()       // method
        {                                  // Supposed to be on the Main function  
            Car2 Ford = new Car2();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Car2 Opel = new Car2();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Ford.fullThrottle();

            Console.WriteLine(Opel.model);
            Opel.fullThrottle();
        }*/
    }

    // Constructors
    class Car3
    {
        public string model;  // Create a field

        // Create a class constructor for the Car class
        public Car3() // constructor name must match the class name
                     // and it cannot have a return type (like void or int).
        {
            model = "Mustang"; // Set the initial value for model
        }
    }

    class Car4
    {
        public string model;
        public string color;
        public int year;

        // Create a class constructor with multiple parameters
        public Car4(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
    }

    // Properties
    class Person
    {
        // Long-hand
        //private string name; // field

        //public string Name   // property
        //{
        //    get { return name; }   // get method
        //    set { name = value; }  // set method
        //}

        // Short-hand
        public string Name  // property
        { get; set; }
    }

    // Inheritance
    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
    class Car5 : Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }

    // If you don't want other classes to inherit from a class, use the sealed keyword
    /*
    sealed class Vehicle
    {
     ...
    }

    class Car : Vehicle
    {
     ...
    }                               // 'Car': cannot derive from sealed type 'Vehicle'
    */

    // Polymorphism
    class Animal  // Base class (parent) 
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    // Abstraction
    // Abstract class: Can contain regular/public methods
    abstract class Animal2
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Pig2 : Animal2
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    // Interfaces
    // Interface: Can only contain abstract methods and properties (with empty bodies)
    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    class Pig3 : IAnimal
    {
        public void animalSound() // you do not have to use the override keyword when implementing an interface
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    // Multiple Interfaces
    interface IFirstInterface
    {
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }

    // Enums
    // Enum can also be implemented inside a class
    enum Level
    {
        Low,
        Medium,
        High
    }
    enum Months
    {
        January,    // 0
        February,   // 1
        March,      // 2
        April,      // 3
        May,        // 4
        June,       // 5
        July        // 6
    }
    enum Months2
    {
        January,    // 0
        February,   // 1
        March = 6,    // 6
        April,      // 7
        May,        // 8
        June,       // 9
        July        // 10
    }
}