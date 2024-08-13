using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Healthcare_System
{
    internal class Patient : User
    {
        public static List<Patient> _patientsList = new List<Patient>(); 
        private string Medical {  get; set; }

        public Patient(string firstName, string lastName, int id, string Medical) : base(firstName, lastName, id)
        {
            this.Medical = Medical; 
        }

        public void AddUser(string filepath)
        {

            _patientsList.Add(this);
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

        }

        public override void RemoveUser() 
        { 
            //base.RemoveUser(user);  

        }

        public void DisplayUser()
        {
            
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Specialty: {Medical}.");


        }

    }
}
