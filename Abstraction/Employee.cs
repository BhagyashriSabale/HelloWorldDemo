using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDemo.Abstraction
{
    internal abstract class Employee
    {
        public string name;

        public abstract void GetSalary();

        public void GetEmployeeDetails()
        {
            Console.WriteLine(" Name of the employee is:"+name);
        }
    }
}
