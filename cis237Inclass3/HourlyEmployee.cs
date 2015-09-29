using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass3
{
    class HourlyEmployee : Employee
    {

        //D: private variable for the hourlyRate
        private decimal hourlyRate;
        private double hoursWorked;

        public double HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }


        //Property for the variable
        public decimal HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }

        //D: Parameter constructor that calls the base constructor with 3 of the paraments, and then
        //asigns the last one to the hourly rate.
        public HourlyEmployee(string FirstName, string LastName, string Department, decimal HourlyRate): 
            base(FirstName, LastName, Department)
        {
            this.hourlyRate = HourlyRate;
        }

        //Override the ToString method.
        //base: is the parent's method, not on my own.
        public override string ToString()
        {
            return base.ToString() + " " + hourlyRate.ToString("C");
        }

        //D:
        //Note: Did not override the printFulName protected virtual method
        //Even though it is protected and virtual, we aren't going to override it.
        //Calling it will just call the parent version.


        //D: Public method to calculate the gross weekly pay.
        //public decimal CalculateWeeklyGross(double HoursWorked)
        //{
        //    return hourlyRate * (decimal)HoursWorked; 
        
        //}

        public decimal CalculateWeeklyGross()
        {
            return hourlyRate * (decimal)hoursWorked;

        }
    }
}
