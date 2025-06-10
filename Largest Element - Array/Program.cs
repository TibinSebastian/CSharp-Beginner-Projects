using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the elements of an array");
            string data = Console.ReadLine();
            string[] parts = data.Split(' ');
            int[] arr = Array.ConvertAll(parts, int.Parse);
            int size = arr.Length;
            int large = arr[0];
            for (int i = 0; i < size; i++)
            {
                if (large < arr[i])
                {
                    large = arr[i];
                }
            }
            Console.WriteLine("Largest element is : " + large);
        }
    }
}