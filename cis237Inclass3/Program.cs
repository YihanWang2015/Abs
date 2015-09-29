using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass3
{
    class Program
    {
        static void Main(string[] args)
        {

            SalaryEmployee salaryEmployee = new SalaryEmployee("David", "Barnes","IT", 150000);

            Console.WriteLine(salaryEmployee.ToString());

            Console.WriteLine(salaryEmployee.CalculateWeeklyGross());

            Console.WriteLine("\n");
            Console.WriteLine("*****************************");
            Console.WriteLine("\n");

            HourlyEmployee hourlyEmployee = new HourlyEmployee("Joe", "Somebody", "HR", 8.37m);
            hourlyEmployee.HoursWorked = 40;


            Console.WriteLine(hourlyEmployee.ToString());
            Console.WriteLine(hourlyEmployee.CalculateWeeklyGross());
        }
    }
}
