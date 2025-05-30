using System;

// namespace MyFirstProgram
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("It's really good");
//             Console.WriteLine("I like pizza");
//             // Console.Beep(); // make the console beep
//             Console.WriteLine("\tHello, World!"); // tab space
//             Console.WriteLine("Hello, \nWorld!"); // new line

//             Console.ReadKey();
//         }
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("What's your name?");
//         string name = Console.ReadLine();

//         Console.WriteLine("How old are you?");
//         int age = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Hello, " + name + "!");
//         Console.WriteLine("You are " + age + " years old.");

//         Console.ReadKey();
//     }
// }

// static void Main(string[] args)
// {
//     Random random = new Random()
//     int num = random.Next(1, 7);
//     Console.WriteLine("Rolling a die...");
//     Console.WriteLine("You rolled a " + num + "!");
//     Console.ReadKey();

// static void Main(string[] args)
// {
//     Console.WriteLine("Please enter your age: ");
//     int age = Convert.ToInt32(Console.ReadLine())
//     if (age >= 100)
//     {
//         Console.WriteLine("You are too old to sign up.");
//     }
//     else if (age < 0)
//     {
//         Console.WriteLine("Invalid age entered.");
//     }
//     else if (age >= 18)
//     {
//         Console.WriteLine("You are now signed up!")
//     }
//     else
//     {
//         Console.WriteLine("You are not old enough to sign up.");
//     }
//     Console.ReadKey();
// }

// static void Main(string[] args)
// {
//     Console.WriteLine("Please enter your name: ");
//     string name = Console.ReadLine();
//     if (name == "Thibaud")
//     {
//         Console.WriteLine("Acces granted, Thibaud!");
//     }
//     else if (name == "")
//     {
//         Console.WriteLine("You didn't enter a name.");
//     }
//     else
//     {
//         Console.WriteLine("Access denied, " + name + "!");
//     }
//     Console.ReadKey();
// }

// static void Main(string[] args)
// {
//     Console.WriteLine("Enter a day of the week: ");
//     string day = Console.ReadLine().ToLower()
//     switch (day)
//     {
//         case "monday":
//             Console.WriteLine("It's Monday! Have a great start to the week!");
//             break;
//         case "tuesday":
//             Console.WriteLine("It's Tuesday! Keep going strong!");
//             break;
//         case "wednesday":
//             Console.WriteLine("It's Wednesday! You're halfway through the week!");
//             break;
//         case "thursday":
//             Console.WriteLine("It's Thursday! Almost there!");
//             break;
//         case "friday":
//             Console.WriteLine("It's Friday! The weekend is almost here!");
//             break;
//         case "saturday":
//             Console.WriteLine("It's Saturday! Enjoy your weekend!");
//             break;
//         case "sunday":
//             Console.WriteLine("It's Sunday! Relax and recharge for the week ahead!");
//             break;
//         default:
//             Console.WriteLine("That's not a valid day of the week. Please try again.");
//             break
//         Console.ReadKey();
//     }

// static void Main(string[] args)
// {
//     Console.WriteLine("Enter your name: ");
//     string name = Console.ReadLine()
//     while (name == "")
//     {
//         Console.Write("Enter your name: ");
//         name = Console.ReadLine();
//     }
//     Console.WriteLine("Hello, " + name + "!");
//     Console.ReadKey();
// }

// static void Main(string[] args)
// {
//     int i = 0
//     while (i < 10)
//     {
//         Console.WriteLine("The value of i is: " + i);
//         i++;
//     }
//     Console.WriteLine("Loop finished! The final value of i is: " + i)
//     for (int j = 0; j < 10; j++)
//     {
//         Console.WriteLine("The value of j is: " + j);
//     }
//     Console.WriteLine("Loop finished! The final value of j is: 10")
//     Console.ReadKey();
// }

// static void Main(string[] args)
// {
//     Console.WriteLine("Enter the number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine())
//     Console.WriteLine("Enter the number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine())
//     Console.WriteLine("What symbol do you want to use? ");
//     string symbol = Console.ReadLine()
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write(symbol);
//         }
//         Console.WriteLine(); // Move to the next line after printing a row
//     }

// static void Main(string[] args)
// {
//     string[] cars = new string[3];
//     // string[] cars = { "BMW", "Mustang", "Corvette" }
//     cars[0] = "Tesla";
//     cars[1] = "Mustang";
//     cars[2] = "Corvette"
//     for (int i = 0; i < cars.Length; i++)
//     {
//         Console.WriteLine(cars[i]);
//     
//     Console.ReadKey();
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         string[] cars = { "BMW", "Mustang", "Corvette" };

//         foreach (string car in cars)
//         {
//             Console.WriteLine(car);
//         }
//         Console.ReadKey();
//     }

// class Program
// {
//     static void Main(string[] args)
//     {
//         string name = "Yibo";
//         int age = 21; 

//         singHappyBirthday(name, age);
//         singHappyBirthday(name, age);
//         singHappyBirthday(name, age);


//         Console.ReadKey();
//     }
//     static void singHappyBirthday(string name, int age)
//     {
//         Console.WriteLine("Happy Birthday To You!");
//         Console.WriteLine("Happy Birthday To You!");
//         Console.WriteLine($"Happy Birthday dear {name}!");
//         Console.WriteLine($"You're {age} years old!");
//         Console.WriteLine("Happy Birthday To You!\n");
//     }
// }

// static void Main(string[] args)
// {
//     double x;
//     double y;
//     double result;

//     Console.WriteLine("Enter number 1: ");
//     x = Convert.ToDouble(Console.ReadLine());

//     Console.WriteLine("Enter number 2: ");
//     y = Convert.ToDouble(Console.ReadLine());

//     result = Multiply(x, y);

//     Console.WriteLine($"Your result is: {result}!");

//     Console.ReadKey();
// }
// static double Multiply(double x, double y)
// {
//     double z = x * y;
//     return z; 
// }

// static void Main(string[] args)
// {
//     double total;

//     total = Multiply(2, 3, 4);

//     Console.WriteLine(total);
//     Console.ReadKey();
// }
// static double Multiply(double a, double b)
// {
//     return a * b;
// }
//  static double Multiply(double a, double b, double c)
// {
//     return a * b * c; 
// }

// // params
// static void Main(string[] args)
// {
//     double total = CheckOut(3.99, 5.75, 15, 1.45, 10.25);

//     Console.WriteLine(total);
//     Console.ReadKey();
// }
// static double CheckOut(params double[] prices)
// {
//     double total = 0;

//     foreach (double price in prices)
//     {
//         total += price;
//     }
//     return total; 
// }

// static void Main(string[] args)
// {
//     double temperature = 20;
//     string message;
//     message = (temperature >= 15) ? "It's hot outside" : "It's cold outside";
//     Console.WriteLine(message);
//     Console.ReadKey();

// static void Main(string[] args)
// {
//     // multidimensional arrays
//     string[,] parkingLot = {{ "Mustang", "F-150", "Explorer"},
//                             { "Corvette", "Camaro", "Silverado"},
//                             { "Corolla", "Camry", "Rav4"}
//     };

//     parkingLot[0, 2] = "Fusion";
//     parkingLot[2, 0] = "Tacoma";

//     // foreach (string car in parkingLot)
//     // {
//     //     Console.WriteLine(car);
//     // }

//     for (int i = 0; i < parkingLot.GetLength(0); i++)
//     {
//         for (int j = 0; j < parkingLot.GetLength(1); j++)
//         {
//             Console.Write(parkingLot[i, j] + " ");
//         }
//         Console.WriteLine();
//     }

//     Console.ReadKey();
// }

// Introduction to classes
// class Program
// {
//     static void Main(string[] args)
//     {
//         Messages.Hello();
//         Messages.Waiting();
//         Messages.Bye();

//         Console.ReadKey();
//     }
// }

// Objects
// class Program
// {
//     static void Main(string[] args)
//     {
//         Human human1 = new Human("Enzo", 19);
//         Human human2 = new Human("evan", 19);

//         human1.Eat();
//         human1.Sleep();

//         human2.Sleep();
//         human2.Eat();

//     }
// }
// class Human
// {
//     public string name;
//     public int age;


//     public Human(string name, int age)
//     {
//         this.name = name;
//         this.age = age; 
//     }

//     public void Eat()
//     {
//         Console.WriteLine(name + " is eating");
//     }
//     public void Sleep()
//     {
//         Console.WriteLine(name + " is sleeping");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Car car1 = new Car("Toyota", "Corolla", 1989, "Red");


//         car1.PrintModel();

//         Console.ReadKey();
//     }
// }

// class Car
// {
//     public string brand;
//     public string model;
//     public int year;
//     public string color;

//     public Car(string brand, string model, int year, string color)
//     {
//         this.brand = brand;
//         this.model = model;
//         this.year = year;
//         this.color = color; 
//     }

//     public void PrintModel()
//     {
//         Console.WriteLine($"This car is a {color} {brand} {model} from {year}");
//     }
// }

//Static
// class Program
// {
//     static void Main(string[] args)
//     {
//         Car car1 = new Car("Mustang");
//         Car car2 = new Car("Corvette");

//         Console.WriteLine(Car.numberOfCars);
//         Car.StartRace(); 

//         Console.ReadKey();
//     }
// }
// class Car
// {
//     string model;
//     public static int numberOfCars;

//     public Car(string model)
//     {
//         this.model = model;
//         numberOfCars++;
//     }
//     public void PrintCar()
//     {
//         Console.WriteLine($"this car is a {model}");
//     }

//     public static void StartRace()
//     {
//         Console.WriteLine("The race has begun"); 
//     }
// }

// Class overloading
// class Program
// {
//     static void Main(string[] args)
//     {
//         Pizza pizza = new Pizza("Stuffed crust", "red sauce", "mozzarella", "pepperoni");

//         Console.ReadKey();

//     }
// }
// class Pizza
// {
//     string bread;
//     string sauce;
//     string cheese;
//     string topping;

//     public Pizza(string bread, string sauce, string cheese, string topping)
//     {
//         this.bread = bread;
//         this.sauce = sauce;
//         this.cheese = cheese;
//         this.topping = topping;
//     }
//     public Pizza(string bread, string sauce, string cheese)
//     {
//         this.bread = bread;
//         this.sauce = sauce;
//         this.cheese = cheese;
//     }
// }

// inheritance
// class Program
// {
//     static void Main(string[] args)
//     {
//         Car car = new Car();
//         Bicycle bicycle = new Bicycle();
//         Boat boat = new Boat();

//         Console.WriteLine(car.speed);
//         Console.WriteLine(car.wheels);
//         car.go();

//         Console.WriteLine(bicycle.speed);
//         Console.WriteLine(bicycle.wheels);
//         bicycle.go();

//         Console.WriteLine(boat.speed);
//         Console.WriteLine(boat.wheels);
//         boat.go();

//         Console.ReadKey();

//     }
// }
// class Vehicle
// {
//     public int speed = 0;

//     public void go()
//     {
//         Console.WriteLine("This vehicle is moving");
//     }
// }
// class Car : Vehicle
// {
//     public int wheels = 4;
// }
// class Bicycle : Vehicle
// {
//     public int wheels = 2;
// }
// class Boat : Vehicle
// {
//     public int wheels = 0;
// }

// List of objects
// class Program
// {
//     static void Main(string[] args)
//     {
//         Car[] garage = {
//             new Car("Mustang"),
//             new Car("Corvette"),
//             new Car("Lambo"),
//         };

//         foreach (Car car in garage)
//         {
//             Console.WriteLine(car.model);
//         }

//         Console.ReadKey();
//     }
// }
// class Car
// {
//     public string model;

//     public Car(string model)
//     {
//         this.model = model;
//     }
// }

//objects as arguments
// class Program
// {
//     static void Main(string[] args)
//     {
//         Car car1 = new Car("Mustang", "Red");

//         Car car2 = Copy(car1);

//         ChangeColor(car1, "Green");

//         Console.WriteLine(car1.color + " " + car1.model);
//         Console.WriteLine(car2.color + " " + car2.model);


//         Console.ReadKey();

//     }
//     public static void ChangeColor(Car car, string color)
//     {
//         car.color = color;
//     }
//     public static Car Copy(Car car)
//     {
//         return new Car(car.model, car.color); 
//     }
// }
// class Car
// {
//     public string model;
//     public string color;

//     public Car(string model, string color)
//     {
//         this.color = color;
//         this.model = model;
//     }
// }


namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();

            Console.ReadKey();
        }
    }
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes *brr*");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes waouf");
        }
    }
    class Cat : Animal
    { 
        public override void Speak()
        {
            Console.WriteLine("The dog goes meow");
        }
    }
}




