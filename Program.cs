using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hello World");
            Console.WriteLine("Code pushing by 2nd Developers");
            Console.WriteLine("Modifying in local repository");
            Console.WriteLine("Good Morning");
            Console.WriteLine("Modifying in remote repo");
            Console.WriteLine("Hello");
            //object syntax
            //Classname variable=new ClassName
            Human human = new Human();
            //display msh on output screen
            Console.WriteLine("Please enter human name");
            //reading input from output screen
            //reading input from output screen
            human.name = Console.ReadLine();
            Console.WriteLine("please enter your height");
            human.height = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("please enter your weight");
            human.weight = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("please enter your age");
            human.age = Convert.ToInt32(Console.ReadLine());
            human.Speak();
            human.HumanDetails(human.name, human.height, human.weight, human.age);

        }
    }
}
