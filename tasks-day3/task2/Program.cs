namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            //new+array = allocation and initialization

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee();
                //allocate for each Employee + data initialization for Class
                Console.WriteLine("enter your ssn:");
                employees[i].SetSsn(int.Parse(Console.ReadLine()));
                Console.WriteLine("enter your name:");
                employees[i].SetName((Console.ReadLine()));
                Console.WriteLine("enter your age:");
                employees[i].SetAge(int.Parse(Console.ReadLine()));
                Console.WriteLine("enter your salary:");
                employees[i].SetSalary(float.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i].printV2());
            }
        }
    }
}
