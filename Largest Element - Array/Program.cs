using System;
//
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
            for (int i = 0; i < size-1; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (arr[j] < arr[j+1])
                    {
                        int swap = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = swap;
                    }
                }
            }
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}