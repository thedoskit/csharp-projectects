using System;
using System.Collections.Generic;

namespace Todo_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
           TodoList todolist = new TodoList();
            
            while(true)
            {
                Console.WriteLine("To-Do List App menu");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Remove Task");
                Console.WriteLine("3. Mark as Completed");
                Console.WriteLine("4. Display Tasks");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Chooos your prefered option: ");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1: 
                        todolist.AddTask();
                        break;

                    case 2:
                        todolist.RemoveTask();
                        break;
                    case 3:
                        todolist.MarkTaskAsCompleted();
                        break;
                    case 4:
                        todolist.DisplayTasks();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Enter any number from 1 to 5.");
                        break;
                }
            }
        }
    }

}
