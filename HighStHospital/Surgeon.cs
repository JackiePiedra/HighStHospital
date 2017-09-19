using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStHospital
{
    class Surgeon : Employee
    {
        private string specialtyArea;
        private bool isOperating;

        public Surgeon(string employeeName, int employeeNumber, string specialtyArea, bool isOperating)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
            this.isOperating = isOperating;
        }

        public override void EmployeeList()
        {
            string employeeList = ($"{employeeName}\t\t{employeeNumber}\t{specialtyArea}\t{isOperating}");
            if (isOperating == true)
            {
                string operating = ($"{employeeName} is operating right now.\n");
                Console.WriteLine(employeeList);
                Console.WriteLine(operating);
            }
            else
            {
                Console.WriteLine(employeeList);
            }
        }

    //    public override void EmployeeStatus()
    //    {
    //        if(isOperating ==true)
    //        {
    //            string operating = ($"{employeeName} is operating right now.\n");
    //        }
    //    }
    //}
}
}
