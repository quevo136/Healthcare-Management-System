using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Healthcare_System
{
    internal class Nurse : User
    {
        public List<Nurse> _nurseList = new List<Nurse>();
        private string Department {  get; set; }
        public Nurse(string firstName, string lastName, int id, string Department) : base(firstName, lastName, id)
        { 
            this.Department = Department;
        
        }

        public void AddUser(string filepath)
        {
            //base.AddUser(user);
            _nurseList.Add(this);
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath, true))
                {

                    file.WriteLine(Id + ": " + FirstName + " " + LastName);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("this program not success: " + ex);
            }
            //Console.WriteLine("Successful");


        }

        public override void RemoveUser()
        {

            base.RemoveUser();
            //_nurseList.Remove();

        }

        public void DisplayUser(User user)
        {
            
            Console.WriteLine("First Name: " + FirstName);
            Console.WriteLine("Last Name: " + LastName);
            Console.WriteLine("Specialty: " + Department);


        }
    }
}
