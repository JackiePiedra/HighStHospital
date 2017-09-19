using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] employeeGroups = { "doctors", "surgeons", "nurses", "administrators", "receptionists", "janitors" };
            //foreach (string department in employeeGroups)
            //{
            //    new List<department>();
            //}

            List<Doctor> doctors = new List<Doctor>();
            Doctor Anthony = new Doctor("Anthony", 123, "Oncology");
            Doctor Paul = new Doctor("Paul", 789, "Pediatrics");
            doctors.Add(Anthony);
            doctors.Add(Paul);
            foreach (Doctor name in doctors)
            {
                name.EmployeeList();
            }

            List<Surgeon> surgeons = new List<Surgeon>();
            Surgeon Chrissy = new Surgeon("Chrissy", 224, "Oncology",true);
            Surgeon Andrea = new Surgeon("Andrea", 345, "Neurology",false);
            surgeons.Add(Chrissy);
            surgeons.Add(Andrea);
            foreach (Surgeon name in surgeons)
            {
                name.EmployeeList();
            }

            List<Nurse> nurses = new List<Nurse>();
            Nurse Carmela = new Nurse("Carmela", 675, 4);
            Nurse Meadow = new Nurse("Meadow", 111,  6);
            nurses.Add(Carmela);
            nurses.Add(Meadow);
            foreach (Nurse name in nurses)
            {
                name.EmployeeList();
            }

            List<Administrator> administrators = new List<Administrator>();
            Administrator AJ = new Administrator("AJ", 342, "Oncology");
            Administrator Sil = new Administrator("Sil", 910, "Pediatrics");
            administrators.Add(AJ);
            administrators.Add(Sil);
            foreach (Administrator person in administrators)
            {
                person.EmployeeList();
            }

            List<Receptionist> receptionists = new List<Receptionist>();
            Receptionist Rosalie = new Receptionist("Rosalie", 448, "Radiology", false);
            Receptionist Angie = new Receptionist("Angie", 789, "Neurology", true);
            Receptionist Janice = new Receptionist("Janice", 332, "Laboratory", true);
            receptionists.Add(Rosalie);
            receptionists.Add(Angie);
            receptionists.Add(Janice);
            foreach (Receptionist name in receptionists)
            {
                name.EmployeeList();
            }

            List<Janitor> janitors = new List<Janitor>();
            Janitor Phil = new Janitor("Phil", 787, "Orthopedics", true);
            Janitor Johnny = new Janitor("Johnny", 337, "Pediatrics", false);
            janitors.Add(Phil);
            janitors.Add(Johnny);
            foreach (Janitor name in janitors)
            {
                name.EmployeeList();
            }

         
            
        }
    }
}
