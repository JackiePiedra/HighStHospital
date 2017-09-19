using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStHospital
{
    class Doctor : Employee
    {
        private string specialtyArea;

        public Doctor(string employeeName, int employeeNumber, string specialtyArea)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
        }

        public override void EmployeeList()
        {
            string employeeList = ($"{employeeName}\t\t{employeeNumber}\t{specialtyArea}");
            Console.WriteLine(employeeList);
        }

    }


}
