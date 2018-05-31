using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateMenu();
        }

        private static List<Student> list = new List<Student>();

        private static void AddStudent()
        {
            var student = new Student();
            Console.WriteLine("Please enter student rollnumber:");
            student.RollNumber = Console.ReadLine();
            Console.WriteLine("Please enter student name:");
            student.Name = Console.ReadLine();
            Console.WriteLine("Please enter student mail:");
            student.Email = Console.ReadLine();
            Console.WriteLine("Please enter student phone:");
            student.Phone = Console.ReadLine();
            list.Add(student);
        }

        private static void DisplayStudent()
        {
            foreach (var student in list)
            {
                Console.WriteLine(student.Name);
            }
        }

        private static void SearchByName()
        {
            Console.WriteLine("Please enter name to search:");
            var searchKey = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                Student student = list[i];
                if (student.Name == searchKey)
                {
                    Console.WriteLine("Found:");
                    Console.WriteLine(student.RollNumber + "-" + student.Name);
                    {
                    }
                }
            }
        }

        private static void GenerateMenu()
        {
            while (true)
            {
                Console.WriteLine("----------Student Manager------------");
                Console.WriteLine("1. Add new student.");
                Console.WriteLine("2. Show list student.");
                Console.WriteLine("3. Search student.");
                Console.WriteLine("4. Exit.");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Please enter your choice:");
                var choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        DisplayStudent();
                        break;
                    case 3:
                        SearchByName();
                        break;
                    case 4:
                        Environment.Exit(1);
                        break;
                }
            }
        }
    }
}