using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("hamada");

            int age;
            Console.WriteLine("Enter your age");
            age = int.Parse(Console.ReadLine());
            string name;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            float salary;
            Console.WriteLine("Enter your salary");
            salary = float.Parse(Console.ReadLine());
            Console.WriteLine($"HEllo {name}");
            Console.WriteLine($"your age is {age},your salary is {salary}");


        }
    }
}
