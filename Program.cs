// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

using System.IO;  // include the System.IO namespace

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a comment
            Console.WriteLine("Hello, World!"); // This is a comment too
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It's awesome!");
            Console.WriteLine(3 + 3);

            /* The code below will print the words Hello World
            to the screen, and it's amazing */
            Console.Write("Hello World! ");
            Console.WriteLine("I will print on the same line.");

            // Leave empty line
            Console.WriteLine();
            
            // Learn about variables
            string name;
            name = "Ichsan";
            Console.WriteLine(name);

            int age = 21;
            Console.WriteLine(age);

            double grade = 89.01;
            Console.WriteLine(grade);

            char gradeChar;
            gradeChar = 'A';
            Console.WriteLine(gradeChar);

            bool isAccepted;
            isAccepted = false;
            Console.WriteLine(isAccepted);

            // Leave empty line
            Console.WriteLine();

            // Learn about constants
            const int myNum = 15;
            // myNum = 20; // Can't overwrite existing value; Error; Read-only
            Console.WriteLine(myNum);

            // Leave empty line
            Console.WriteLine();

            // Learn about display variables
            Console.WriteLine("Hello " + name);

            string firstName = "Ichsan";
            string lastName = "Hibatullah";
            string fullName = firstName + " " + lastName;
            Console.WriteLine("My full name is " + fullName);

            int firstNum = 5;
            int secondNum = 6;
            Console.WriteLine(firstNum + secondNum); // Print the value of x + y

            // Leave empty line
            Console.WriteLine();

            // Learn about multiple variables
            int x = 7, y = 8, z = 50;
            Console.WriteLine(x + y + z);

            int a, b, c;
            a = b = c = 50;
            Console.WriteLine(a + b + c);

            // Leave empty line
            Console.WriteLine();

            // Learn about identifiers
            // Good
            int minutesPerHour = 60;

            // OK, but not so easy to understand what m actually is
            int m = 60;

            // Learn about data types
            /*
            Data Type	Size	                Description
            int	        4 bytes	                Stores whole numbers from -2,147,483,648 to 2,147,483,647
            long	    8 bytes	                Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            float	    4 bytes	                Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
            double	    8 bytes	                Stores fractional numbers. Sufficient for storing 15 decimal digits
            bool	    1 byte	                Stores true or false values
            char	    2 bytes	                Stores a single character/letter, surrounded by single quotes
            string	    2 bytes per character	Stores a sequence of characters, surrounded by double quotes 
            */

            // Int
            int intNum = 100000;
            Console.WriteLine(intNum);

            // Long
            long longNum = 15000000000L;
            Console.WriteLine(longNum);

            // Float
            float floatNum = 5.75F;
            Console.WriteLine(floatNum);

            // Double
            double doubleNum = 19.99D;
            Console.WriteLine(doubleNum);

            // Scientific Numbers
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            // Booleans
            bool isCSharpFun = true;
            bool isPorkTasty = false;
            Console.WriteLine(isCSharpFun); // Output True
            Console.WriteLine(isPorkTasty); // Output False

            // Characters
            char myGrade = 'A';
            Console.WriteLine(myGrade);

            // Strings
            string greeting = "Hello World";
            Console.WriteLine(greeting);

            // Leave empty line
            Console.WriteLine();

            // Learn about type casting
            // Implicit Casting (Automatic)
            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9

            // Explicit Casting (Manual)
            double myDoubleEx = 9.78;
            int myIntEx = (int)myDoubleEx;    // Manual casting: double to int

            Console.WriteLine(myDoubleEx);   // Outputs 9.78
            Console.WriteLine(myIntEx);      // Outputs 9

            int myInt2 = 10;
            double myDouble2 = 5.25;
            bool myBool2 = true;

            Console.WriteLine(Convert.ToString(myInt2));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt2));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble2));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool2));   // convert bool to string

            // Leave empty line
            Console.WriteLine();

            // Learn about user input
            // Type your username and press enter
            Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);

            Console.WriteLine("Enter your age:");
            int myAge = Convert.ToInt32(Console.ReadLine()); // int age = Console.ReadLine(); // Cannot implicitly convert type 'string' to 'int'
            Console.WriteLine("Your age is: " + myAge);

            // Leave empty line
            Console.WriteLine();

            // Learn about operators
            // Arithmetic
            int sum1 = 100 + 50;        // 150 (100 + 50) // Addition
            int sum2 = sum1 + 250;      // 400 (150 + 250)
            int sum3 = sum2 + sum2;     // 800 (400 + 400)

            Console.WriteLine(100 - 50); // Substraction
            Console.WriteLine(25 * 2); // Multiplication
            Console.WriteLine(24 / 2); // Division
            Console.WriteLine(26 % 9); // Modulus
            Console.WriteLine(sum1++); // Increment
            Console.WriteLine(sum1--); // Decrement

            // Assignment
            sum1 = 0;
            sum1 += 5; // Addition
            sum1 -= -5; // Substraction
            sum1 *= 10; // Multiplication
            sum1 /= 10; // Division
            sum1 %= 3; // Modulus
            sum1 &= 3; // Bitwise AND operator
            sum1 |= 3; // Bitwise OR operator
            sum1 ^= 3; // Bitwise XOR operator
            sum1 >>= 3; // Right-shift assignment
            sum1 <<= 3; // Left-shift assignment

            // Comparison
            Console.WriteLine(sum1 == 0); // Equal to
            Console.WriteLine(sum1 != 0); // Not equal
            Console.WriteLine(sum1 > 0); // Greater than
            Console.WriteLine(sum1 < 0); // Less than
            Console.WriteLine(sum1 >= 0); // Greater than or equal to
            Console.WriteLine(sum1 <= 0); // Less than or equal to

            // Logical Operators
            Console.WriteLine(sum1 == 0 && sum1 >= 0); // Logical and; Returns True if both statements are true
            Console.WriteLine(sum1 < 5 || sum1 > 2); // Logical or ;Returns True if one of the statements is true
            Console.WriteLine(!(sum1 == 0 && sum1 > 2)); // Logical not; Reverse the result, returns False if the result is true

            // Leave empty line
            Console.WriteLine();

            // Learn about math
            Math.Max(5, 10);
            Math.Min(5, 10);
            Math.Sqrt(64);
            Math.Abs(-4.98);
            Math.Round(9.29);

            // Learn about strings
            // Strings
            string greeting1 = "Hello";
            string greeting2 = "Nice to meet you!";

            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);

            string txt1 = "Hello World";
            Console.WriteLine(txt1.ToUpper());
            Console.WriteLine(txt1.ToLower());

            // Concatenation
            string firstName1 = "John";
            string lastName1 = "Doe";
            string name1 = firstName1 + lastName1;
            Console.WriteLine(name1);
            string name2 = string.Concat(firstName1, lastName1);
            Console.WriteLine(name2);

            int x1 = 10;
            int y1 = 20;
            int z1 = x1 + y1;  // z will be 30 (an integer/number)

            string x2 = "10";
            string y2 = "20";
            string z2 = x2 + y2;  // z will be 1020 (a string)

            // Interpolation
            string firstName2 = "John";
            string lastName2 = "Doe";
            string name3 = $"My full name is: {firstName2} {lastName2}";
            Console.WriteLine(name3);

            // Access Strings
            string myString = "Hello";
            Console.WriteLine(myString[0]);  // Outputs "H"
            Console.WriteLine(myString[1]);  // Outputs "e"
            Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"

            string name4 = "John Doe";
            int charPos = name4.IndexOf("D");
            string lastName3 = name4.Substring(charPos);
            Console.WriteLine(lastName3);

            // Special Characters
            /*
            Escape character	Result	    Description
            \'	                '	        Single quote
            \"	                "	        Double quote
            \\	                \	        Backslash
            */
            string txt2 = "We are the so-called \"Vikings\" from the north.";
            string txt3 = "It\'s alright.";
            string txt4 = "The character \\ is called backslash.";

            /*
            Code	Result
            \n	    New Line	
            \t	    Tab	
            \b	    Backspace
            */

            // Leave empty line
            Console.WriteLine();

            // Learn about booleans
            bool isProgrammingFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isProgrammingFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False

            Console.WriteLine(10 > 9); // returns True, because 10 is higher than 9

            Console.WriteLine(10 == 15); // returns False, because 10 is not equal to 15

            int myAge1 = 25;
            int votingAge = 18;

            if (myAge1 >= votingAge)
            {
                Console.WriteLine("Old enough to vote!");
            }
            else
            {
                Console.WriteLine("Not old enough to vote.");
            }

            // Leave empty line
            Console.WriteLine();

            // Learn about if else
            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }

            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            // Outputs "Good evening."

            // Short Hand
            int time1 = 20;
            string result = (time1 < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            // Leave empty line
            Console.WriteLine();

            // Learn about switch
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            // Outputs "Thursday" (day 4)

            int day1 = 4;
            switch (day1)
            {
                case 6:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }
            // Outputs "Looking forward to the Weekend."

            // Leave empty line
            Console.WriteLine();

            // Learn about while loop
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            int j = 0;
            do // Do once, then repeat until condition is false
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 5);

            // Leave empty line
            Console.WriteLine();

            // Learn about for loop
            for (int k = 0; k <= 10; k = k + 2)
            {
                Console.WriteLine(k);
            }

            // Outer loop
            for (int ii = 1; ii <= 2; ++ii)
            {
                Console.WriteLine("Outer: " + ii);  // Executes 2 times

                // Inner loop
                for (int jj = 1; jj <= 3; jj++)
                {
                    Console.WriteLine(" Inner: " + jj); // Executes 6 times (2 * 3)
                }
            }

            // Foreach loop
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            // Leave empty line
            Console.WriteLine();

            // Learn about break/continue
            // break
            for (int n = 0; n < 10; n++)
            {
                if (n == 4)
                {
                    break;
                }
                Console.WriteLine(n);
            }

            int p = 0;
            while (p < 10)
            {
                Console.WriteLine(p);
                p++;
                if (p == 4)
                {
                    break;
                }
            }

            // continue
            for (int o = 0; o < 10; o++)
            {
                if (o == 4)
                {
                    continue;
                }
                Console.WriteLine(o);
            }

            int q = 0;
            while (q < 10)
            {
                if (q == 4)
                {
                    q++;
                    continue;
                }
                Console.WriteLine(q);
                q++;
            }

            // Leave empty line
            Console.WriteLine();

            // Learn about arrays
            string[] carBrands = { "Volvo", "BMW", "Ford", "Mazda" };
            int[] myNums = { 10, 20, 30, 40 };

            Console.WriteLine(carBrands[0]);
            // Outputs Volvo

            carBrands[0] = "Opel";
            Console.WriteLine(carBrands[0]);
            // Now outputs Opel instead of Volvo

            // Ways of creating an array
            // Create an array of four elements, and add values later
            string[] carBrands1 = new string[4];

            // Create an array of four elements and add values right away 
            string[] carBrands2 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            string[] carBrands3 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] carBrands4 = { "Volvo", "BMW", "Ford", "Mazda" };

            // Loop through an array
            for (int r = 0; r < carBrands.Length; r++) // For loop
            {
                Console.WriteLine(cars[r]);
            }

            foreach (string s in carBrands) // Foreach loop; Better
            {
                Console.WriteLine(s);
            }

            // Sort Arrays
            // Sort a string
            string[] cars2 = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars2);
            foreach (string t in cars2)
            {
                Console.WriteLine(t);
            }

            // Sort an int
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int u in myNumbers)
            {
                Console.WriteLine(u);
            }

            // Using System.Linq Namespace. Other useful array methods, such as Min, Max, and Sum.
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

            // Multidimensional Arrays
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            Console.WriteLine(numbers[0, 2]);  // Outputs 2

            numbers[0, 0] = 5;  // Change value to 5
            Console.WriteLine(numbers[0, 0]); // Outputs 5 instead of 1

            foreach (int v in numbers)
            {
                Console.WriteLine(v);
            }

            for (int w = 0; w < numbers.GetLength(0); w++)
            {
                for (int d = 0; d < numbers.GetLength(1); d++)
                {
                    Console.WriteLine(numbers[w, d]);
                }
            }

            // Leave empty line
            Console.WriteLine();

            // Learn about methods
            MyMethod(); // Outputs "I just got executed!"

            for (int e = 0; e < 3; e++)
            {
                MyMethod();
            }

            // Leave empty line
            Console.WriteLine();

            // Learn about method parameters
            // Parameters
            MyMethodArg("Ichsan", 22);

            // Default Parameters
            MyMethodDefault();
            MyMethodDefault("Norway");

            // Return Values
            Console.WriteLine(MyMethodReturn(5, 3));
            Console.WriteLine(MyMethodReturn(y: 6));
            int all_def = MyMethodReturn();
            Console.WriteLine(all_def);

            // Named Arguments
            ChildName(name1: "Liam", name2: "John", name3: "Abdul");

            // Leave empty line
            Console.WriteLine();

            // Learn about method overloading
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);

            // Leave empty line
            Console.WriteLine();

            // Learn about OOP & Classes/Objects
            Car myCar = new Car();
            Console.WriteLine(myCar.color);

            // Leave empty line
            Console.WriteLine();

            // Learn about class Members
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

            // Leave empty line
            Console.WriteLine();

            // Learn about constructors
            Car3 Ford2 = new Car3();  // Create an object of the Car Class (this will call the constructor)
            Console.WriteLine(Ford2.model);  // Print the value of model

            Car4 Ford3 = new Car4("Mustang", "Red", 1969);
            Car4 Opel2 = new Car4("Astra", "White", 2005);
            Console.WriteLine(Ford3.color + " " + Ford3.year + " " + Ford3.model);
            Console.WriteLine(Opel2.color + " " + Opel2.year + " " + Opel2.model);

            // Leave empty line
            Console.WriteLine();

            // Learn about access modifiers
            /* private: it can only be accessed within the same class
               public: it is accessible for all classes
               By default, all members of a class are private */

            // Learn about properties
            /* The meaning of Encapsulation, is to make sure that "sensitive"
               data is hidden from users.To achieve this, you must:
               - declare fields/ variables as private
               - provide public get and set methods, through properties,
                 to access and update the value of a private field */
            /* Fields can be made read - only(if you only use the get method),
               or write-only(if you only use the set method) */
            Person myPerson = new Person();
            myPerson.Name = "Liam";
            Console.WriteLine(myPerson.Name);

            // Leave empty line
            Console.WriteLine();

            // Learn about inheritance
            // Create a myCar2 object
            Car5 myCar2 = new Car5();
            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar2.honk();
            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar2.brand + " " + myCar2.modelName);

            // Leave empty line
            Console.WriteLine();

            // Learn about polymorphism
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

            // Leave empty line
            Console.WriteLine();

            // Learn about abstraction
            // Animal2 myAnimal2 = new Animal2(); // Will generate an error (Cannot create an instance of the abstract class or interface 'Animal')

            Pig2 myPig2 = new Pig2(); // Create a Pig object
            myPig2.animalSound();  // Call the abstract method
            myPig2.sleep();  // Call the regular method

            // Leave empty line
            Console.WriteLine();

            // Learn about interface
            // Interface
            Pig3 myPig3 = new Pig3();  // Create a Pig object
            myPig3.animalSound();

            /*
            Notes on Interfaces:
            - Like abstract classes, interfaces cannot be used to create objects(in the example above, it is not possible to create an "IAnimal" object in the Program class)
            - Interface methods do not have a body - the body is provided by the "implement" class
            - On implementation of an interface, you must override all of its methods
            - Interfaces can contain properties and methods, but not fields/variables
            - Interface members are by default abstract and public
            - An interface cannot contain a constructor(as it cannot be used to create objects) */

            // C# does not support "multiple inheritance" (a class can only inherit from one base class).
            // However, it can be achieved with interfaces, because the class can implement multiple interfaces.
            // Note: To implement multiple interfaces, separate them with a comma (see example in the next chapter).

            // Multiple Interface
            DemoClass myDemo = new DemoClass();
            myDemo.myMethod();
            myDemo.myOtherMethod();

            // Leave empty line
            Console.WriteLine();

            // Learn about enums
            // An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).
            Level myLevel = Level.Medium;
            Console.WriteLine(myLevel);
            // Enums are often used in switch statements to check for corresponding values
            switch (myLevel)
            {
                case Level.Low:
                    Console.WriteLine("Low level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium level");
                    break;
                case Level.High:
                    Console.WriteLine("High level");
                    break;
            }

            int myMonth = (int)Months.April;
            Console.WriteLine(myMonth); // Outputs 3

            int myMonth2 = (int)Months2.April;
            Console.WriteLine(myMonth2); // Outputs 7

            // Leave empty line
            Console.WriteLine();

            // Learn about files
            /*
            The File class has many useful methods for creating and getting information about files.For example:
            Method              Description
            AppendText()        Appends text at the end of an existing file
            Copy()              Copies a file
            Create()            Creates or overwrites a file
            Delete()            Deletes a file
            Exists()            Tests whether the file exists
            ReadAllText()       Reads the contents of a file
            Replace()           Replaces the contents of a file with the contents of another file
            WriteAllText()      Creates a new file and writes the contents to it.If the file already exists, it will be overwritten.
            */

            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("helloWorld.txt", writeText);  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText("helloWorld.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the content

            // Leave empty line
            Console.WriteLine();

            // Learn about exceptions
            try
            {
                int[] myList = { 1, 2, 3 };
                Console.WriteLine(myList[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }

            checkAge(20);
            checkAge(15); // Unhandled exception. System.ArithmeticException: Access denied - You must be at least 18 years old.
        }

        // Methods
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        // Method Parameters
        static void MyMethodArg(string fname, int age)
        {
            Console.WriteLine(fname + " Hibatullah" + " is " + age);
        }

        static void MyMethodDefault(string country = "Indonesia")
        {
            Console.WriteLine("My nationality is " + country);
        }

        static int MyMethodReturn(int x = 0, int y = 0)
        {
            return x + y;
        }

        static void ChildName(string name1, string name2, string name3)
        {
            Console.WriteLine("The youngest child is: " + name3);
        }

        // Method Overloading
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        // Exceptions (try.. catch) => throw
        /*
        The throw statement allows you to create a custom error.
        The throw statement is used together with an exception class.
        There are many exception classes available in C#: ArithmeticException,
        FileNotFoundException, IndexOutOfRangeException, TimeOutException, etc.
        */
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }
    }
}