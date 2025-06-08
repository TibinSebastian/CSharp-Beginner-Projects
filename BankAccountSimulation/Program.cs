using System;

namespace Project
{
    class Bank
    {
        static int balance = 0;

        public static void deposit(int value)
        {
            balance = balance + value;
            Console.WriteLine($"Your balance is ${balance}");
        }

        public static void withdraw(int value)
        {
            if (value > balance)
            {
                Console.WriteLine("Insuffiecient Balance");
            }
            else
            {
                balance = balance - value;
                Console.WriteLine($"Your balance is ${balance}");
            }
        }
        public static void acc_balance()
        {
            Console.WriteLine($"Your balance is ${balance}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("what do you want to perform\n1. Deposit\n2. Withdraw\n3. Check Balance\n4. Exit\nchoice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                int value;
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the amount to deposit: ");
                        value = Convert.ToInt32(Console.ReadLine());
                        Bank.deposit(value);
                        break;
                    case 2:
                        Console.Write("Enter the amount to withdraw: ");
                        value = Convert.ToInt32(Console.ReadLine());
                        Bank.withdraw(value);
                        break;
                    case 3:
                        Bank.acc_balance();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid entry....");
                        break;
                }
            }
        }
    }
}
