using task7_struct;
namespace task7_employesArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[10];
            int index;
            char flag;
            do
            {
                do
                {
                    Console.WriteLine("enter index [0 : 9]");
                    index = int.Parse(Console.ReadLine());
                } while (index < 0 || index > 9);

                if (employees[index].ssn != 0)
                {
                    Console.WriteLine("exist overwrite? y or n");
                    char x = char.Parse(Console.ReadLine());
                    if (x == 'n')
                    {
                        do
                        {
                            Console.WriteLine("enter index [0 : 9]");
                            index = int.Parse(Console.ReadLine());
                        } while (index < 0 || index > 9);

                    }
                }
                Console.WriteLine("enter you ssn");
                employees[index].ssn = int.Parse(Console.ReadLine());
                Console.WriteLine("enter you name");
                employees[index].name = Console.ReadLine();
                do
                {
                    Console.WriteLine("enter you age");
                    employees[index].age = int.Parse(Console.ReadLine());
                } while (employees[index].age < 18 || employees[index].age > 60);
                Console.WriteLine("enter you salary");
                employees[index].salary = int.Parse(Console.ReadLine());
                Console.WriteLine("continue y or n");
                flag = char.Parse(Console.ReadLine());
            }
            while (flag == 'y');

            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].ssn != 0)
                {
                    Console.WriteLine($"Welcome {employees[i].name}");
                    Console.WriteLine($" {employees[i].name}'s Snn : {employees[i].ssn}");
                    Console.WriteLine($" {employees[i].name}'s Age : {employees[i].age}");
                    Console.WriteLine($" {employees[i].name}'s Salary : {employees[i].salary}");
                    Console.WriteLine("================================================");
                }
            }
        }
    }
}