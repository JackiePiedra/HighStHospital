using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStHospital
{
    class Employee
    {
        //fields
        protected string employeeName;
        protected int employeeNumber;
        protected double hourlyWage;
        protected double hoursWorked;

        //properties
        public string EmployeeName
        {
            get { return this.employeeName; }
        }

        public int EmployeeNumber
        {
            get { return this.employeeNumber; }
        }

        public double HoursWorked
        {
            get { return this.hoursWorked; }
            set { this.hoursWorked = value; }
        }

        public double HourlyWage
        {
            get { return this.hourlyWage; }
            set { this.hourlyWage = value; }
        }

        //constructors
        public Employee()
        {

        }

        public Employee(string employeeName, int employeeNumber)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
        }

        //methods
        public virtual double WeeklyPay(double hoursWorked, double hourlyWage)
        {
            double paycheck = hoursWorked * hourlyWage;
            return paycheck;
        }

        public virtual void EmployeeList()
        {
            string employeeInfo = ($"{employeeName}\t\t{employeeNumber}");
            Console.WriteLine(employeeInfo);
        }

        //public virtual void EmployeeStatus()
        //{
        //    string employeeStatus = ($"{employeeName}");
        //}
    }
}
