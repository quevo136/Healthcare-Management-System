using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Healthcare_System
{
    internal class MedicalRecord
    {
        private static List<MedicalRecord> _medicalRecordList = new List<MedicalRecord>();
        public Patient Patient { get; set; } 
        public Doctor Doctor { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }

        public MedicalRecord(Patient patient, Doctor doctor, string diagnosis, string treatment ) 
        { 
            this.Patient = patient;
            this.Doctor = doctor;
            this.Diagnosis = diagnosis;
            this.Treatment = treatment;

            _medicalRecordList.Add(this);        
        }

       
        public void deleteRecod(Patient patient, Doctor doctor)
        {

        }

        public void updateRecord(string newDiagnosis, string newTreatment)
        {
            this.Treatment = newDiagnosis;
            this.Diagnosis = newTreatment; 

        }

        public void displayRecord(Patient patient, Doctor doctor)
        {
            //patient.DisplayUser(patient);
            //doctor.DisplayUser(doctor);
            
        }
    }
}
