using System;
using System.Collections.Generic;

namespace MyTemplateProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the student's name (or 'exit' to quit):");
                string name = Console.ReadLine();
                if (name.ToLower() == "exit")
                {
                    break;
                }
                else if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Name cannot be empty. Please try again.");
                    continue;
                }
                else
                {
                    Console.WriteLine("Enter the subject name with its marks");
                    List<string> sub_names = new List<string>();
                    List<int> sub_mark = new List<int>();
                    List<int> sub_total_mark = new List<int>();
                    List<char> sub_grade = new List<char>();

                    while (true)
                    {
                        Console.Write("Enter the subject name (if finished type 'exit') : ");
                        string sub = Console.ReadLine();
                        if (sub.ToLower() == "exit")
                        {
                            break;
                        }
                        sub_names.Add(sub);

                        Console.Write("Enter the subject mark : ");
                        int mark = Convert.ToInt32(Console.ReadLine());
                        sub_mark.Add(mark);

                        Console.Write("Enter the subject total mark : ");
                        int total = Convert.ToInt32(Console.ReadLine());
                        sub_total_mark.Add(total);
                    }

                    for(int i = 0; i < sub_names.Count; i++)
                    {
                        float grade = ((float)sub_mark[i] / sub_total_mark[i]) * 100;
                        if (grade >= 81)
                        {
                            sub_grade.Add('A');
                        } 
                        else if (grade >= 66 && grade < 81)
                        {
                            sub_grade.Add('B');
                        }
                        else if (grade >= 51 && grade < 66)
                        {
                            sub_grade.Add('C');
                        }
                        else if (grade >= 41 && grade < 51)
                        {
                            sub_grade.Add('D');
                        }
                        else
                        {
                            sub_grade.Add('F');
                        }
                    }
                    Console.WriteLine("The students marks are, ");
                    for (int i = 0; i < sub_names.Count; i++)
                    {
                        Console.WriteLine($"Student: {name}, Subject: {sub_names[i]} - Grade: {sub_grade[i]}");
                    }
                }
            }
        }
    }
}
