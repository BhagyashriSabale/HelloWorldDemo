using HelloWorldDemo.Inheritance;
using HelloWorldDemo.Polymorphism;
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
            Console.WriteLine("Please choose 1program from below options");
            Console.WriteLine("1.Human\n2.Inheritance\n3.Method Overloading\n4.Methos Overriding");
            int option=Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
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
                    break;

                 case 2:
                    Car car = new Car();
                    car.modelNumber = 2022;
                    car.brand = "BMW";
                    car.Start();
                    break;

                case 3:
                    Addition addition = new Addition();
                    addition.AddNumbers(10,34.56,60);
                    break;

                case 4:
                    Animal animal = new Animal();
                    animal.name = "Elephant";
                    animal.AnimalDetails();
                    animal.Run();

                    Lion lion = new Lion();
                    lion.name = "Lion";
                    lion.AnimalDetails();
                    lion.Run();
                    break;

                default:
                    Console.WriteLine("Please choose program with given options ");
                    break;
            }
            
            
            
        }
    }
}
