using System;

namespace TimesTableExercice
{
    class Program
    {
        // Ask the user for a number for the table
        // Write a for loop to print X times table
        static void Main(string[] args)
        {
            int inputInt = 0;
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input) || !input.All(char.IsDigit))
            {
                Console.WriteLine("Please enter a valid name");
            }
            else
            {
                inputInt = Convert.ToInt32(input);
            }

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, inputInt, i * inputInt);
            }

            Console.ReadLine();

        }
    }
}