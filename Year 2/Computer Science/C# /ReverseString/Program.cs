using System;

namespace ReverseStringExercise
{
    class Program
    {
        // ask user to imput message 
        // Print the message
        // print the reversed message
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter your message");

            string message = Console.ReadLine();

            if (string.IsNullOrEmpty(message))
            {
                System.Console.WriteLine("Please enter a valid sentence");
            }

            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = message.Length - 1; i >= 0; i--)
            {
                Console.Write(message[i]);
            }
            
            Console.ReadLine();
        }
    }
}