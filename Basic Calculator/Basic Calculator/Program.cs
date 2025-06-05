using System;

namespace MyTemplateProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a basic calculator");
            do
            {
                Console.Write("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter an operator (+, -, *, /): ");
                char op = Console.ReadKey().KeyChar;
                switch (op)
                {
                    case '+':
                        Console.WriteLine($"\nResult: {num1 + num2}");
                        break;
                    case '-':
                        Console.WriteLine($"\nResult: {num1 - num2}");
                        break;
                    case '*':
                        Console.WriteLine($"\nResult: {num1 * num2}");
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            Console.WriteLine($"\nResult: {num1 / num2}");
                        }
                        else
                        {
                            Console.WriteLine("\nError: Division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("\nError: Invalid operator. Please use +, -, *, or /.");
                        break;
                }
                Console.Write("Do you want to perform another calculation? (y/n): ");
                char again = Console.ReadKey().KeyChar;
                if (again != 'y' && again != 'Y')
                {
                    Console.WriteLine("\nExiting the calculator. Goodbye!");
                    break;
                }
            } while (true); 
        }
    }
}

