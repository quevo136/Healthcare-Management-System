using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Healthcare_System
{
    public abstract class User
    {
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public int Id { get; set; }


        public User(string firstName, string lastName, int id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;

        }

        public virtual void AddUser(string filepath) { }
        public virtual void RemoveUser() { }
        public virtual void UpdateUser() { }
        public virtual void DisplayUser() { }
        




    }
}
