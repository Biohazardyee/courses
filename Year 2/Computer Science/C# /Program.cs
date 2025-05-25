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

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int num = random.Next(1, 7);

            Console.WriteLine("Rolling a die...");
            Console.WriteLine("You rolled a " + num + "!");




            Console.ReadKey();
        }
    }
}