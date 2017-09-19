using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStHospital
{
    class Janitor : Employee
    {
        private string department;
        private bool isSweeping;

        public Janitor(string employeeName, int employeeNumber, string department, bool isSweeping)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.isSweeping = isSweeping;
        }

        public override void EmployeeList()
        {
            string employeeList = ($"{employeeName}\t\t{employeeNumber}\t{department} \t{isSweeping}");
            if (isSweeping == true)
            {
                string sweeping = ($"{employeeName} is sweeping right now.\n");
                Console.WriteLine(employeeList);
                Console.WriteLine(sweeping);
            }
            else
            {
                Console.WriteLine(employeeList);
            }
        }
    }
}
