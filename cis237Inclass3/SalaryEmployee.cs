using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass3
{
    //inherited from employee
    class SalaryEmployee : Employee
    {
        // D: Private variable for yearly salary
        private decimal yearlySalary;

        //D: Public property for yearly salary

        //refector ->encaptsolute field   from above
        public decimal YearlySalary
        {
            get { return yearlySalary; }
            set { yearlySalary = value; }
        }


        //there's no constructor in parent class that has zero argument 
        //so have to make it to the 3 paraments constructor
        public SalaryEmployee(string FirstName, string LastName, string Department, decimal YearlySalary):base(FirstName, LastName, Department)
        {
            this.yearlySalary = YearlySalary;
        }


        //D: Override the ToString method to include the salary
        public override string ToString()
        {
           
            return base.ToString() + " " + this.yearlySalary.ToString();
        }

        //D: Override of a method that WE wrote. Requires the method in the Employee
        //class to be declared as virtual. It is also protected so that any sub classes
        //that inherit from this class can use it.
        protected override void PrintFullName()
        {
            Console.WriteLine(base.ToString() + " " + this.yearlySalary.ToString());
        }


        //D: A public method to return the weekly gross for the employee.
        public decimal CalculateWeeklyGross()
        {
            return this.yearlySalary / 52;
        }

    }
}
