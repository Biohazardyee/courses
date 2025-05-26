// namespace MyFirstProgram
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Random random = new Random();
//             int numberToGuess = random.Next(1, 101);
//             int userGuess = 0;
//             int attempts = 0;
//             bool hasWon = false;

//             Console.WriteLine("Welcome to the Number Guessing Game!");

//             while (!hasWon)
//             {
//                 Console.WriteLine("Try guessing the number: ");
//                 if (int.TryParse(Console.ReadLine(), out userGuess))
//                 {
//                     attempts++;
//                     if (userGuess > numberToGuess)
//                     {
//                         Console.WriteLine(userGuess + " is too high, try again");
//                     }
//                     else if (userGuess < numberToGuess)
//                     {
//                         Console.WriteLine(userGuess + " is too low, try again");
//                     }
//                     else
//                     {
//                         hasWon = true;
//                         Console.WriteLine($"Congratulations! You found the number {numberToGuess} in {attempts} attempts!");
//                     }
//                 }
//                 else
//                 {
//                     Console.WriteLine("Please enter a valid number!");
//                 }
//             }
//         }
//     }
// }