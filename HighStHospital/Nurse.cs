using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStHospital
{
    class Nurse : Employee
    {
        private int numberOfPatients;

        public Nurse(string employeeName, int employeeNumber, int numberOfPatients)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.numberOfPatients = numberOfPatients;
        }

        public override void EmployeeList()
        {
            string employeeList = ($"{employeeName}\t\t{employeeNumber}\t{numberOfPatients}");
            string patients = ($"{employeeName} has {numberOfPatients} patients right now.\n");
            Console.WriteLine(employeeList);
            Console.WriteLine(patients);
        }
    }
}
