using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass3
{
    abstract class Employee : IEmployee
    {
        //Private variables
        private string firstName;
        private string lastName;
        private string department;

        //Propertiest for variables
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        //3 Parameter Constructor
        public Employee(string FirstName, string LastName, string Department)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.department = Department;
        }

        public override string ToString()
        {
            //return base.ToString();  would be the same result which shows the class name

            return this.FirstName + " " + this.LastName;
        }

        //protected can only be seen in inherited members.
        //virtual indicates that subclass is allowed to override
        protected virtual void PrintFullName()
        {
          //  Console.WriteLine(this.FirstName + " " + this.LastName);
        
        }

        public abstract decimal CalculateWeeklyGross();




        public virtual string GetDepartmentTwice()
        {
            return this.Department + this.Department;
        }
     
    }
}
