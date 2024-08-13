// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello,Worldssss");

using Healthcare_System;
using System;
using System.Data.Common;
using System.IO;
using System.Text;
using System.Linq;
using System.Numerics;
using System.Runtime.ExceptionServices;

namespace Healthcare_System
{
    class Program
    {
        public static void Main(string[] args)
        {
            string? readResult;
            string? readId ;
            string menuSelection = "";
            string appSelection = "";

            //Add Doctor List
            List<Doctor> _doctorList = new List<Doctor> {
            new Doctor("Micheal", "Truong", 1, "Doctor"),
            new Doctor("Anna", "Nguyen", 2, "Doctor"),
            new Doctor("Jonno", "Vu", 3, "Doctor"),
            new Doctor("John", "Doe", 4, "Cardiology"),
            new Doctor("Jane", "Smith", 5, "Dermatology"),
            new Doctor("Emily", "Jones", 6, "Emergency Medicine"),
            };


            //Console.WriteLine(string.Join(" ", Doctor.readDoctorList("4", "doctors.csv", 1)));
            //Console.ReadLine();

            //Search user in doctors list:
            //Console.WriteLine(string.Join(" ", Doctor.readDoctorList("2", "doctors.csv", 1)));


            ////Edit user to doctors list:      
            do
            {
                Console.Clear();

                Console.WriteLine("Which doctor info you want to update: ");
                Console.WriteLine("1: Doctor ID ");
                Console.WriteLine("2: Doctor First Name");
                Console.WriteLine("3: Doctor Last Name");
                Console.WriteLine("Enter your selection number, or type \"exit\" to exit the program");

                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    menuSelection = readResult.ToLower();
                }

                switch (menuSelection)
                {
                    // Create Profile

                    case "1":
                        do
                        {
                            Console.WriteLine("Please Select Id:");
                            readResult = Console.ReadLine();

                            if(int.TryParse(readResult, out int id))
                            {
                                Doctor doctorToUpdate = _doctorList.Find(d => d.Id == id);

                                if (doctorToUpdate != null)
                                {
                                    Console.WriteLine("Please Change ID to: ");
                                    string newSpecialty = Console.ReadLine();
                                    doctorToUpdate.UpdateUser(readResult, "doctors.csv", 1 , newSpecialty);

                                    Console.WriteLine("Doctor updated successfully.");
                                }
                                else
                                {
                                    Console.WriteLine("Doctor not found.");
                                }
                            }
                                          
                            


                        } while (readResult == null);
                        break;

                }

            } while ( appSelection != "");

            foreach (var doctor in _doctorList)
            {
                //Add user to doctors list:                
                //doctor.AddUser("doctors.csv");       

            }
            Console.WriteLine("Doctor Success Added");
            
                //***** List of nurse
            List<Nurse> nurses = new List<Nurse>
            {
                new Nurse("Alice", "Johnson", 1, "Cardiac Care Unit (CCU)"),
                new Nurse("Bella", "Williams", 2, "Critical Care Unit (ICU)"),
                new Nurse("Catherine", "Brown", 3, "Emergency Department (ED)"),
                new Nurse("Daisy", "Miller", 4, "Geriatric Nursing"),
                new Nurse("Ella", "Davis", 5, "Labor and Delivery (L&D)"),
                new Nurse("Fiona", "Wilson", 6,  "Medical-Surgical Nursing"),
            };

            foreach (var nurse in nurses)
            {
                //nurse.AddUser("nurse.csv");
            }
            Console.WriteLine("Nurse Success Added");


                //Doctor.DisplayDoctorList();
                //Console.WriteLine(Doctor.DisplayDoctorList);

                //****** Patient List
            List<Patient> patients = new List<Patient>
            {
                new Patient("Rafael", "Nadal",1, "diabetes"),
                new Patient("Novak", "Djokovic", 2, "diabetes2"),
                new Patient("Roger", "Federer", 3, "short-sighted")

            };

            foreach (var patient in patients)
            {
                //patient.AddUser("patient.csv");
            }
            Console.WriteLine("Patients Success Added");          


        }
    }
}