using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStHospital
{
    class Receptionist : Employee
    {
        private string department;
        private bool isOnThePhone;

        public Receptionist(string employeeName, int employeeNumber, string department, bool isOnThePhone)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.isOnThePhone = isOnThePhone;
        }

        public override void EmployeeList()
        {
            string employeeList = ($"{employeeName}\t\t{employeeNumber}\t{department}\t{isOnThePhone}");
            if (isOnThePhone == true)
            {
                
                string onThePhone = ($"{employeeName} is on the phone right now.\n");
                Console.WriteLine(employeeList);
                Console.WriteLine(onThePhone);
            }
            else
            {
                Console.WriteLine(employeeList);
            }
        }
    }
}
