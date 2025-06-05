using System;
using System.Runtime.InteropServices;

namespace MyTemplateProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Guess a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            Random random = new Random();
            int randomNumber = random.Next(0, 100);

            if ( number == randomNumber)
            {
                Console.WriteLine("Guess Correct");
            }
            else
            {
                Console.WriteLine("Guess Incorrect");
                Console.WriteLine($"The correct number was {randomNumber}");
            }
        }
    }
}
