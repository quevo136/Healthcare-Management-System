using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Numerics;

namespace Healthcare_System
{


    internal class Doctor : User
    {

        private static int _doctorId = 1;
        public static List<Doctor> _doctorsList = new List<Doctor>();
        public string Specialty { get; set; }
        public Doctor(string firstName, string lastName, int id, string Specialty) : base(firstName, lastName, id)
        {
            this.Specialty = Specialty;

        }

        public void AddUser( string filepath)
        {

            _doctorsList.Add(this); 
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath, true))
                {
                    
                    file.WriteLine(Id + " " + FirstName + " " + LastName);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("this program not success: " + ex);
            }
            
        }


        public static string[] readDoctorList(string searchTerm, string filepath, int positionOfSearchTerm)
        {
            positionOfSearchTerm--;
            string[] recordNotFound = { "Records not found" };

            try
            {
                string[] lines = File.ReadAllLines(filepath);

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(' ');

                    // có thể thử đổi vảiable(eg:id) để kiếm kq ????
                    if(recordMatches(searchTerm, fields, positionOfSearchTerm))
                    {
                        Console.WriteLine("Records Found");
                        return fields;
                    }
                }

                return recordNotFound;


            }
            catch (Exception ex)
            {
                Console.WriteLine("This program did an oppsie");
                return recordNotFound;
                throw new Exception("this program did an oppsie: ", ex);
            }
        }

        public static bool recordMatches(string searchTerm, string[] record, int positionOfSearchTerm)
        {
            if (record[positionOfSearchTerm].Equals(searchTerm))
            {
                return true;
            }
            return false;
        }

        public override void RemoveUser()
        {

            
            //base.RemoveUser(user);
            //_doctorsList.Append();

        }
        
        
        public void UpdateUser(string searchTerm, string filepath, int positionOfSearchTerm, string updateField)
        {
            positionOfSearchTerm--;
            string tempfile = "temp.csv";
            bool edited = false;
            try
            {
                string[] lines = File.ReadAllLines(filepath);


                for (int i = 0; i < lines.Length; i++)
                {
                    string [] fields = lines[i].Split(" ");
                    if(!(recordMatches(searchTerm, fields, positionOfSearchTerm)))
                    {
                        AddUser(tempfile);
                        Console.WriteLine("This person not in the list");
                    }
                    else
                    {
                        if(!edited)
                        {
                            AddUser(tempfile);
                            Console.WriteLine("Edited done");
                            edited = true;
                        }
                    }

                }

                //Delete old file
                File.Delete(filepath);
                //Rename new file 
                File.Move(tempfile, filepath);
                Console.WriteLine("Records Edited");


            }
            catch (Exception ex)
            {
                Console.WriteLine("this program did an oppsie");
                throw new ApplicationException("this program did an oopsie: ", ex);
            }   

        }


        public void DisplayDoctor()
        {
            

            //base.DisplayUser(user);
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Specialty: {Specialty}.");

        }

        public static void DisplayDoctorList()
        {
            foreach (Doctor doctor in _doctorsList)
            {
                
                doctor.DisplayDoctor();
         
            }
                        
        }


    }
}
