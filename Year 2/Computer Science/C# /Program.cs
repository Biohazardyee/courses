using System;
using System.Collections.Generic;
using System.Threading;

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

// ToString method
// class Program
// {
//     static void Main(string[] args)
//     {
//         Car car = new Car("Chevy", "Corvette", 2022, "Blue");

//         Console.WriteLine(car.ToString());

//         Console.ReadKey();
//     }
// }

// class Car
// {
//     string brand;
//     string model;
//     int year;
//     string color;

//     public Car(string brand, string model, int year, string color)
//     {
//         this.brand = brand;
//         this.model = model;
//         this.year = year;
//         this.color = color;
//     }

//     public override string ToString()
//     {
//         string message = $"This is a {color} {brand} {model} from {year}";
//         return message;
//     }
// }

// polymorphism
// class Program
// {
//     static void Main(string[] args)
//     {
//         Car car = new Car();
//         Bicycle bicycle = new Bicycle();
//         Boat boat = new Boat();

//         Vehicle[] vehicles = { car, bicycle, boat };

//         foreach (Vehicle vehicle in vehicles)
//         {
//             vehicle.Go();
//         }

//         Console.ReadKey();
//     }
// }
// class Vehicle
// {
//     public virtual void Go()
//      {
//         Console.WriteLine("The vehicule is going!");
//     }
// }
// class Car : Vehicle
// {
//     public override void Go()
//     {
//         Console.WriteLine("The car is going!");
//     }
// }
// class Bicycle : Vehicle
// {
//     public override void Go()
//     {
//         Console.WriteLine("The bicycle is going!");
//     }
// }
// class Boat : Vehicle
// {
//     public override void Go()
//     {
//         Console.WriteLine("The boat is going!");
//     }
// } 

// interfaces
// class Program
// {
//     static void Main(string[] args)
//     {
//         Rabbit rabbit = new Rabbit();
//         Hawk hawk = new Hawk();
//         Fish fish = new Fish();

//         hawk.Hunt();

//         rabbit.Flee();

//         fish.Hunt();
//         fish.Flee(); 

//         Console.ReadKey();
//     }
// }
// interface IPrey
// {
//     void Flee();
// }
// interface IPredator
// {
//     void Hunt();
// }
// class Rabbit : IPrey
// {
//     public void Flee()
//     {
//         Console.WriteLine("The rabbit runs away");
//     }
// }
// class Hawk : IPredator
// {
//     public void Hunt()
//     {
//         Console.WriteLine("The hawk is hunting");
//     }
// }
// class Fish : IPredator, IPrey
// {
//     public void Flee()
//     {
//         Console.WriteLine("The fish swims away");
//     }
//     public void Hunt()
//     {
//         Console.WriteLine("The fish is hunting");
//     }
// }

// must be using "using System.Collections.Generic;"
// lists
// class Program
// {
//     static void Main(string[] args)
//     {
//         List<string> food = new List<string>();

//         food.Add("Pizza");
//         food.Add("Hamburger");
//         food.Add("Hotdog");
//         food.Add("Fries");

//         // food.Remove("Fries");

//         food.Insert(0, "Sushi");

//         Console.WriteLine(food.Count); 
//         Console.WriteLine(food.IndexOf("Pizza"));
//         food.Sort();
//         // food.Reverse();
//         // food.Clear();

//         foreach (string item in food)
//         {
//             Console.WriteLine(item);
//         }

//         Console.WriteLine(food[0]);

//         Console.ReadKey();
//     }
// }

// List of objects
// class Program
// {
//     static void Main(string[] args)
//     {
//         List<Player> PlayerList = new List<Player>();

//         // Player player1 = new Player("Chad");
//         // Player player2 = new Player("Steve");
//         // Player player3 = new Player("Bio");

//         PlayerList.Add(new Player("Chad"));
//         PlayerList.Add(new Player("Steve"));
//         PlayerList.Add(new Player("Bio"));

//         foreach (Player player in PlayerList)
//         {
//             Console.WriteLine(player);
//         }

//         Console.ReadKey();
//     }
// }
// class Player
// {
//     public string username;
//     public Player(string username)
//     {
//         this.username = username;
//     }
//     public override string ToString()
//     {
//         return username;
//     }
// }

// setters and getters
// class Program
// {
//     static void Main(string[] args)
//     {
//         Car car = new Car(400);

//         Console.WriteLine(car.Speed);

//         car.Speed = 1000000;
//         Console.WriteLine(car.Speed);


//         Console.ReadKey();

//     }
// }
// class Car
// {
//     public int speed;

//     public Car(int speed)
//     {
//         Speed = speed;
//     }
//     public int Speed
//     {
//         get { return speed; } // read
//         set
//         {
//             if (value > 500)
//             {
//                 speed = 500;
//             }
//             else
//             {
//                 speed = value;
//             }
//         }
//     }
// }


// auto implemented properties
// class Program
// {
//     static void Main(string[] args)
//     {
//         Car car = new Car("Porsche");

//         Console.WriteLine(car.Model);

//         Console.ReadKey();
//     }
// }
// class Car
// {
//     public string Model { get; set; }

//     public Car(string model)
//     {
//         this.Model = model; 
//     }
// }


// enums 
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine(Planets.Pluto + " is as planet");

//         Console.WriteLine(Planets.Mercury + " is planet #" + (int)Planets.Mercury);

//         Console.WriteLine(Planets.Pluto + " is planet #" + (int)Planets.Pluto);

//         string name = PlanetRadius.Earth.ToString();
//         int radius = (int)PlanetRadius.Earth;
//         double volume = Volume(PlanetRadius.Earth);
//         Console.WriteLine("planet: " + name);
//         Console.WriteLine("radius: " + radius + " kms");
//         Console.WriteLine("Volume: " + volume + " km^3");


//         Console.ReadKey();
//     }
//     public static double Volume(PlanetRadius radius)
//     {
//         double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
//         return volume;
//     }
// }
// enum Planets
// {
//     Mercury = 1,
//     Venus = 2,
//     Earth = 3,
//     Mars = 4,
//     Jupiter = 5,
//     Saturn = 6,
//     Uranus = 7,
//     Neptune = 8,
//     Pluto = 9
// }
// enum PlanetRadius
// {
//     Mercury = 2439,
//     Venus = 6051,
//     Earth = 6371,
//     Mars = 3389,
//     Jupiter = 69911,
//     Saturn = 58232,
//     Uranus = 25362,
//     Neptune = 24622,
//     Pluto = 1188

// }


// generic
// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] intArray = { 1, 2, 3 };
//         double[] doubleArray = { 1.0, 2.0, 3.0 };
//         string[] strArray = { "1", "2", "3" };

//         displayElements(intArray);
//         displayElements(doubleArray);
//         displayElements(strArray);


//         Console.ReadKey();
//     }
//     public static void displayElements<Thing>(Thing[] array)
//     {
//         foreach (Thing item in array)
//         {
//             Console.Write(item + " ");
//         }
//         Console.WriteLine();
//     }
// }

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";

            Thread thread1 = new Thread(() => CountDown("Timer #1"));
            Thread thread2 = new Thread(() => CountUp("Timer #2"));

            thread1.Start();
            thread2.Start();

            Console.WriteLine($"Main thread: {mainThread.Name} is complete!");
            Console.ReadKey();
        }

        public static void CountDown(string name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1: " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is complete!");
        }

        public static void CountUp(string name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2: " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is complete!");
        }
    }
}



