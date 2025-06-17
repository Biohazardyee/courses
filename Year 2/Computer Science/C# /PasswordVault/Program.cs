using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace PasswordVaultProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isLoggedIn = false;
            string password = "test";

            string savedPasswordPath = "savedPassword.txt";
            List<Credential> credentials = new List<Credential>();

            // Load saved credentials
            if (File.Exists(savedPasswordPath))
            {
                string[] savedPasswords = File.ReadAllLines(savedPasswordPath);
                foreach (var line in savedPasswords)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        credentials.Add(new Credential(parts[0], parts[1], parts[2]));
                    }
                }
            }

            while (true)
            {

                Console.WriteLine("Enter your password");
                string? newPasswordInput = Console.ReadLine();

                if (newPasswordInput == password)
                {
                    isLoggedIn = true;
                    Console.Clear();
                }

                while (isLoggedIn)
                {
                    Console.WriteLine("Welcome to your password vault");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("1. Add new credentials");
                    Console.WriteLine("2. Remove credentials");
                    Console.WriteLine("3. See saved credentials");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine();

                    string? input = Console.ReadLine();
                    if (!int.TryParse(input, out int choice))
                    {
                        Console.WriteLine("Enter a correct number. Press Enter to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Enter the website's name:");
                            string? websiteInput = Console.ReadLine();

                            Console.WriteLine("Enter your username:");
                            string? usernameInput = Console.ReadLine();

                            Console.WriteLine("Enter your password:");
                            string? passwordInput = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(websiteInput) ||
                                string.IsNullOrWhiteSpace(usernameInput) ||
                                string.IsNullOrWhiteSpace(passwordInput))
                            {
                                Console.WriteLine("One or more fields were empty. Press Enter to continue...");
                                Console.ReadLine();
                                Console.Clear();
                                continue;
                            }

                            credentials.Add(new Credential(websiteInput, usernameInput, passwordInput));
                            SaveCredentials(savedPasswordPath, credentials);
                            Console.WriteLine($"A new account has been created for website {websiteInput}");
                            Console.WriteLine("Press Enter to continue...");
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        case 2:
                            Console.Clear();
                            if (credentials.Count == 0)
                            {
                                Console.WriteLine("You have no credentials to remove.");
                            }
                            else
                            {
                                for (int i = 0; i < credentials.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. Website: {credentials[i].Website}\n   Username: {credentials[i].Username}\n   Password: {credentials[i].Password}");
                                    Console.WriteLine("------------------------------------");
                                }

                                Console.WriteLine("Enter the ID of the credential you wish to remove:");
                                string? removeInput = Console.ReadLine();

                                if (int.TryParse(removeInput, out int removeId) &&
                                    removeId >= 1 && removeId <= credentials.Count)
                                {
                                    credentials.RemoveAt(removeId - 1);
                                    SaveCredentials(savedPasswordPath, credentials);
                                    Console.WriteLine("Credential removed successfully.");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid ID.");
                                }
                            }

                            Console.WriteLine("Press Enter to continue...");
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        case 3:
                            Console.Clear();
                            if (credentials.Count == 0)
                            {
                                Console.WriteLine("You have no saved credentials yet.");
                            }
                            else
                            {
                                for (int i = 0; i < credentials.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. Website: {credentials[i].Website}\n   Username: {credentials[i].Username}\n   Password: {credentials[i].Password}");
                                    Console.WriteLine("------------------------------------");
                                }
                            }

                            Console.WriteLine("Press Enter to continue...");
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        case 4:
                            Console.Clear();
                            Console.WriteLine("Goodbye!");
                            SaveCredentials(savedPasswordPath, credentials);
                            return;

                        default:
                            Console.WriteLine("Invalid option. Press Enter to continue...");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                }
            }
        }

        static void SaveCredentials(string path, List<Credential> credentials)
        {
            File.WriteAllLines(path, credentials.Select(c => $"{c.Website}|{c.Username}|{c.Password}"));
        }
    }

    class Credential
    {
        public string Website { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Credential(string website, string username, string password)
        {
            Website = website;
            Username = username;
            Password = password;
        }
    }
}
