using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStHospital
{
    class Administrator : Employee
    {
        private string department;

        public Administrator(string employeeName, int employeeNumber, string department)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
        }

        public override void EmployeeList()
        {
            string employeeList = ($"{employeeName}\t\t{employeeNumber}\t{department}");
            Console.WriteLine(employeeList);
        }
    }
}
