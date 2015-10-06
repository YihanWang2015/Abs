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

            Console.WriteLine(salaryEmployee.GetDepartmentTwice());

            Console.WriteLine("\n");
            Console.WriteLine("*****************************");
            Console.WriteLine("\n");

            HourlyEmployee hourlyEmployee = new HourlyEmployee("Joe", "Somebody", "HR", 8.37m);
            hourlyEmployee.HoursWorked = 40;


            Console.WriteLine(hourlyEmployee.ToString());
            Console.WriteLine(hourlyEmployee.CalculateWeeklyGross());


    // can't make instance of abstract class
           // Employee employee = new Employee("D", "B", "d");



            Console.WriteLine(hourlyEmployee.GetDepartmentTwice());



            Console.WriteLine("**************");


            //Declare and instanciate one of each type of employee
            HourlyEmployee joe = new HourlyEmployee("Joe", "Somebody","HR", 9.37m);
            joe.HourlyRate = 87;

            SalaryEmployee dave = new SalaryEmployee("Dave","Barnes","IT",150000m);


            Employee spock = new SalaryEmployee("Mr.", "Spock", "ST", 0m);


            IEmployee newPerson = new HourlyEmployee("Some","OneElse","WK", 12.34m);

            ((HourlyEmployee)newPerson).HoursWorked = 21;


            //Create an array of type IEmployee, and pass in the two instances we created.
            //IEmployee can contain instances that are lower on the inheritance chain.
            //(More specific imploementations)
            //Add another on the fly. No need to assign it to a seperate variable first.
            IEmployee[] employeeList = { 
                                           joe,
                                           dave,
                                           new SalaryEmployee("James","Kirk","ST", 0m),
                                           spock
                                       };
            
            //Now we can loop through the list of employees and call the CalculateWeeklyGross
            //On each of the employees. The program will be smart enough to know which 
            //method to call depending on the current instance it is working with.

            foreach(IEmployee employee in employeeList)
            {
                Console.WriteLine(employee.ToString());
                Console.WriteLine(employee.CalculateWeeklyGross());
                Console.WriteLine();
            }


            IEmployee[] anotherEmployeeList;
            anotherEmployeeList = new IEmployee[20];

            anotherEmployeeList[0] = joe;
            anotherEmployeeList[1] = dave;

            foreach (IEmployee employee in anotherEmployeeList)
            {
                Console.WriteLine(employee.ToString());
                Console.WriteLine(employee.CalculateWeeklyGross());
                Console.WriteLine();
            }


        }
    }
}
