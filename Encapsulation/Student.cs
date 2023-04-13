using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDemo.Encapsulation
{
    internal class Student
    {
        private string studentName;
         
        public string Name
        {
            get { return studentName; }

            set 
            {
                if (value.Length >= 3)
                    studentName = value;
                else
                    Console.WriteLine("Please enter minimum 3 letters name");
            }

        }

        // private int MyProperty { get; set;}
    }
}
