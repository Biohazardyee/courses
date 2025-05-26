// namespace MyFirstProgram
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             bool continueCalculating = true;

//             while (continueCalculating)
//             {
//                 double num1;
//                 double num2;
//                 double result;
//                 string? choice;

//                 Console.WriteLine("----------------------------");
//                 Console.WriteLine("This is a calculator program");
//                 Console.WriteLine("----------------------------");

//                 Console.WriteLine("Enter number 1: ");
//                 while (!double.TryParse(Console.ReadLine(), out num1))
//                 {
//                     Console.WriteLine("Invalid input. Please enter a valid number:");
//                 }

//                 Console.WriteLine("Enter number 2: ");
//                 while (!double.TryParse(Console.ReadLine(), out num2))
//                 {
//                     Console.WriteLine("Invalid input. Please enter a valid number:");
//                 }

//                 Console.WriteLine("What do you want to do\n1. Add \n2. Substract \n3. Multiply \n4. Divide");
//                 choice = Console.ReadLine();

//                 switch (choice)
//                 {
//                     case "1":
//                         result = num1 + num2;
//                         Console.WriteLine("Your result is: " + result);
//                         break;
//                     case "2":
//                         result = num1 - num2;
//                         Console.WriteLine("Your result is: " + result);
//                         break;
//                     case "3":
//                         result = num1 * num2;
//                         Console.WriteLine("Your result is: " + result);
//                         break;
//                     case "4":
//                         if (num2 == 0)
//                         {
//                             Console.WriteLine("Error: Cannot divide by zero!");
//                         }
//                         else
//                         {
//                             result = num1 / num2;
//                             Console.WriteLine("Your result is: " + result);
//                         }
//                         break;
//                     default:
//                         Console.WriteLine("Invalid operation selected.");
//                         break;
//                 }

//                 Console.WriteLine("Do you want to calculate again? (yes/no)");
//                 string? response = Console.ReadLine()?.ToLower();
//                 continueCalculating = response == "yes" || response == "y";
//             }

//             Console.WriteLine("Press any key to exit...");
//             Console.ReadKey();
//         }
//     }
// }
