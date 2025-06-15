using System;
using System.Text.RegularExpressions;

namespace PasswordChecker
{
    class Program
    {
        private const int MinPasswordLength = 8;
        private static readonly string SpecialCharacters = @"!@#$%^&*()_+-=[]{}|;:,.<>?";

        static void Main(string[] args)
        {
            while (true)
            {
                string password1 = GetPasswordFromUser("Enter your password:");

                if (string.IsNullOrEmpty(password1))
                {
                    Console.WriteLine("Error: Password cannot be empty.");
                    return;
                }

                if (!IsPasswordStrong(password1))
                {
                    return;
                }

                string password2 = GetPasswordFromUser("Confirm your password:");

                if (string.IsNullOrEmpty(password2))
                {
                    Console.WriteLine("Error: Confirmation password cannot be empty.");
                    return;
                }

                if (password1 == password2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Success: Passwords match and meet all requirements!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Passwords do not match.");
                    Console.ResetColor();
                }
            }
        }
        private static string GetPasswordFromUser(string prompt)
        {
            Console.WriteLine(prompt);
            string password = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                // Handle backspace
                if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password[..^1];
                    Console.Write("\b \b");
                }
                // Add character to password if it's not Enter
                else if (key.Key != ConsoleKey.Enter)
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
            } while (key.Key != ConsoleKey.Enter);

            Console.WriteLine();
            return password;

        }

        private static bool IsPasswordStrong(string password)
        {
            var errors = new List<string>();

            if (password.Length < MinPasswordLength)
            {
                errors.Add($"Password must be at least {MinPasswordLength} characters long.");
            }

            if (!password.Any(char.IsUpper))
            {
                errors.Add("Password must contain at least one uppercase letter.");
            }

            if (!password.Any(char.IsLower))
            {
                errors.Add("Password must contain at least one lowercase letter.");
            }

            if (!password.Any(char.IsDigit))
            {
                errors.Add("Password must contain at least one number.");
            }

            if (!password.Any(c => SpecialCharacters.Contains(c)))
            {
                errors.Add($"Password must contain at least one special character ({SpecialCharacters}).");
            }

            if (errors.Any())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Password Requirements:");
                foreach (var error in errors)
                {
                    Console.WriteLine($"- {error}");
                }
                Console.ResetColor();
                return false;
            }

            return true;
        }
    }
}