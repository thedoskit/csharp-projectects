using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_app
{
    public class Task
    {
        string name;
        string description;
        DateTime dueDate;
        bool completed;

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool Completed { get; set; }

        //constructor
        public Task(string name, string description, DateTime dueDate) 
        {
            name = Name;
            description = Description;
            dueDate = DueDate;
            completed = false;
        }
    }
}
