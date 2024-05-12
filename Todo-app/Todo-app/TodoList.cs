using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Todo_app
{
    public class TodoList
    {
        public int taskNumber;
        public Task task;


        //Properties

        public int TaskNumber
        {
            get { return taskNumber; }
            set { taskNumber = value; }
        }
        public Task Task 
        {
            get { return task; }
            set { task = value; } 
        }


        public TodoList() 
        {
            taskNumber = 0;
            task = null;
        }

        public void AddTask() 
        {
            Console.WriteLine("Enter task name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter task description:");
            string description = Console.ReadLine();

            Console.WriteLine("Enter task due date(yyyy-MM-dd):");
            DateTime dueDate = DateTime.Parse(Console.ReadLine());


            task = new Task(name, description, dueDate);
            taskNumber++;


        }

        public void RemoveTask() 
        {
            Console.WriteLine("Enter the task number to be removed:");
            int taskToRemove = int.Parse(Console.ReadLine());

            if (taskToRemove == taskNumber)
            {
                task = null;
            }
            else 
            {
                Console.WriteLine("Error: Invalid task number");
            }

        }


        public void MarkTaskAsCompleted()
        {
            Console.WriteLine("Enter the task number to be marked as completed");
            int taskToBeMarked =int.Parse(Console.ReadLine());

            if(taskToBeMarked == taskNumber && task != null ) 
            {
                task.Completed = true;
            }

            else
            {
                Console.WriteLine("Error: Task not foumd");
            }
        }

        public void DisplayTasks()
        {
            if( task != null)
            {
                Console.WriteLine($"Task Name: {task.Name}");
                Console.WriteLine($"Task Description: {task.Description}");
                Console.WriteLine($"Task Due Date: {task.DueDate.ToString("yyyy-MM-dd")}");
                Console.WriteLine($"Completed: {task.Completed}");

            }
            else
            {
                Console.WriteLine("No tasks available");
            }
        }


        
    }
}
