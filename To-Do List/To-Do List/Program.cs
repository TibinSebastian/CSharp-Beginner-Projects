using System;
using System.Collections.Generic;

namespace MyTemplateProject
{
    internal class Program
    {
        static List<string> todolist = new List<string>();
        static void AddItem(string item)
        {
            todolist.Add(item);
        }
        static void RemoveItem(string item)
        {
            todolist.Remove(item);
        }
        static void DisplayItems()
        {
            Console.WriteLine("To-Do List:");
            foreach (var item in todolist)
            {
                Console.WriteLine($"- {item}");
            }
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter a command (add, remove, display, exit):");
                string command = Console.ReadLine()?.ToLowerInvariant();
                if (command == "exit")
                {
                    break;
                }
                else if (command == "add")
                {
                    Console.WriteLine("Enter item to add:");
                    string item = Console.ReadLine();
                    if (!string.IsNullOrEmpty(item))
                    {
                        AddItem(item);
                        Console.WriteLine($"Added: {item}");
                    }
                }
                else if (command == "remove")
                {
                    Console.WriteLine("Enter item to remove:");
                    string item = Console.ReadLine();
                    if (!string.IsNullOrEmpty(item) && todolist.Contains(item))
                    {
                        RemoveItem(item);
                        Console.WriteLine($"Removed: {item}");
                    }
                    else
                    {
                        Console.WriteLine($"Item not found: {item}");
                    }
                }
                else if (command == "display")
                {
                    DisplayItems();
                }
                else
                {
                    Console.WriteLine("Unknown command. Please try again.");
                }
            }
        }
    }
}
