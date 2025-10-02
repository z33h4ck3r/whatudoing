using System;
using System.Collections.Generic;

namespace TodoListApp
{
    class Program
    {
        static List<Task> tasks = new List<Task>();

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Task Manager");
                Console.WriteLine("1. Add a task");
                Console.WriteLine("2. Show task list");
                Console.WriteLine("3. Mark task as completed");
                Console.WriteLine("4. Delete a task");
                Console.WriteLine("5. Exit");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    choice = -1; // Invalid input
                }

                switch (choice)
                {
                    case 1:
                        AddTask();
                        break;
                    case 2:
                        ShowTasks();
                        Console.WriteLine("Press Enter to return to menu...");
                        Console.ReadLine();
                        break;
                    case 3:
                        MarkTaskAsDone();
                        break;
                    case 4:
                        DeleteTask();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try again.");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void AddTask()
        {
            string exit = "no";
            while (exit.Equals("no", StringComparison.OrdinalIgnoreCase) || exit.Equals("n", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter the new task:");
                string newTask = Console.ReadLine() ?? string.Empty;

                tasks.Add(new Task(newTask));

                Console.WriteLine("Is that the only task? (Yes/No)");
                exit = Console.ReadLine() ?? string.Empty;
            }
        }

        static void ShowTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks found.");
                return;
            }

            for (int i = 0; i < tasks.Count; i++)
            {
                string status = tasks[i].IsDone ? "[x]" : "[]";
                Console.WriteLine($"{i + 1}. {status} {tasks[i].Description}");
            }
        }

        static void MarkTaskAsDone()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks to mark as completed.");
                Console.WriteLine("Press Enter to return to menu...");
                Console.ReadLine();
                return;
            }

            ShowTasks();
            Console.WriteLine("Enter the number of the task you want to mark as completed:");

            if (int.TryParse(Console.ReadLine(), out int taskNumber))
            {
                if (taskNumber > 0 && taskNumber <= tasks.Count)
                {
                    tasks[taskNumber - 1].IsDone = true;
                    Console.WriteLine("Task marked as completed!");
                }
                else
                {
                    Console.WriteLine("That task number does not exist.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }

            Console.WriteLine("Press Enter to return to menu...");
            Console.ReadLine();
        }

        static void DeleteTask()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks to delete.");
                Console.WriteLine("Press Enter to return to menu...");
                Console.ReadLine();
                return;
            }

            ShowTasks();
            Console.WriteLine("Enter the number of the task you want deleted: ");

            if (int.TryParse(Console.ReadLine(), out int taskNumber))
            {
                if (taskNumber > 0 && taskNumber <= tasks.Count)
                {
                    tasks.RemoveAt(taskNumber - 1);
                    Console.WriteLine($"The task {taskNumber} has been deleted.");
                }
                else
                {
                    Console.WriteLine("That task number does not exist.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }

            Console.WriteLine("Press Enter to return to menu...");
            Console.ReadLine();
        }
    }

    class Task
    {
        public string Description { get; }
        public bool IsDone { get; set; }

        public Task(string description)
        {
            Description = description;
            IsDone = false;
        }
    }
}
