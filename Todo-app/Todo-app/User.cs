using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_app
{
    public class User
    {
        //fields
       private int id;
       private string name;

        public int Id { get; set; }
        public string Name { get; set; }
        //constructor

        public User(int id, string name) 
        { 
            id = Id;
            name = Name;
        
        } 



    }
}
