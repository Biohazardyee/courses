using System;

namespace BankingProject
{
    class Program
    {
        static void Main(string[] args)
        {

            List<BankAccount> BankAccountsList = new List<BankAccount>();

            BankAccount bankAccount = new BankAccount("Thibaud Marlier", "0001", 500.01);
            BankAccountsList.Add(bankAccount);

            while (true)
            {
                Console.WriteLine("\nChoose an action:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Display Info");
                Console.WriteLine("4. Create New Account");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("You chose to deposit");
                        Console.WriteLine();
                        Console.WriteLine("Please enter the amount you wish to deposit.");
                        string depositInput = Console.ReadLine();
                        if (double.TryParse(depositInput, out double depositAmount))
                        {
                            bankAccount.Deposit(depositAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                        }


                        break;

                    case "2":
                        Console.WriteLine("You chose to withdraw.");
                        Console.Write("Please enter the amount to withdraw: ");
                        string withdrawalInput = Console.ReadLine();
                        if (double.TryParse(withdrawalInput, out double withdrawalAmount))
                        {
                            bankAccount.Withdraw(withdrawalAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                        }

                        break;

                    case "3":
                        Console.WriteLine("You chose to see your information.");
                        Console.WriteLine();
                        Console.WriteLine("Hello,");
                        bankAccount.DisplayInfo();
                        break;

                    case "4":
                        Console.WriteLine("Enter the Account Holder's name");
                        string nameInput = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(nameInput) || double.TryParse(nameInput, out _))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid name.");
                            break;
                        }

                        Console.WriteLine("Enter the Account's ID:");
                        string idInput = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(idInput) || !idInput.All(char.IsDigit))
                        {
                            Console.WriteLine("Invalid input. Please enter a numeric ID (digits only).");
                            break;
                        }
                        // Check for duplicate ID
                        bool idExists = BankAccountsList.Any(account => account.AccountNumber == idInput);
                        if (idExists)
                        {
                            Console.WriteLine("An account with this ID already exists. Please enter a unique ID.");
                            break;
                        }


                        Console.WriteLine("Enter the account's balance");
                        string balanceInput = Console.ReadLine();
                        if (double.TryParse(balanceInput, out double balanceAmount))
                        {
                            BankAccount newAccount = new BankAccount(nameInput, idInput, balanceAmount);
                            BankAccountsList.Add(newAccount);
                            Console.WriteLine("New account successfully created!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                        }
                        break;

                    case "5":
                        Console.WriteLine("Bye bye");
                        return;

                    default:
                        Console.WriteLine("Please select a valid value");
                        break;
                }
            }


        }
    }
    class BankAccount
    {
        private double balance;
        private string name;
        private string accountNumber;
        
        public string AccountNumber
        {
            get { return accountNumber; }
        }


        public double Deposit(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("You cannot deposit a negative amount of money");
            }
            else
            {
                balance += amount;
            }
            return balance;
        }
        public double Withdraw(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("You cannot withdraw more money than you have");
            }
            else
            {
                balance -= amount;
            }
            return balance;
        }
        public BankAccount(string name, string accountNumber, double balance)
        {
            this.name = name;
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Account Holder: {name}");
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Balance: {balance:F2}€");

        }

    }
}