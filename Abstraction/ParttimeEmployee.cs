using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDemo.Abstraction
{
    internal class ParttimeEmployee:Employee
    {
        public override void GetSalary()
        {
            Console.WriteLine("56000 ");
        }
    }
}
