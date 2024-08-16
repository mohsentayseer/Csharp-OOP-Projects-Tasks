using System.Diagnostics.Metrics;
using static task1.Employee;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gen;
            int sec;
            int id, salary;
            Employee[] employees = new Employee[1];
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee();
                do
                {
                    Console.Write("Enter Your Id: ");
                } while (!int.TryParse(Console.ReadLine(), out id));
                employees[i].Id = id;
                do
                {
                    Console.Write("Enter Your Salary: ");
                } while (!int.TryParse(Console.ReadLine(), out salary));
                employees[i].Salary = salary;

                bool validHireDate = false;
                while (!validHireDate)
                {
                    Console.WriteLine("Enter your hire date (DD/MM/YYYY)");
                    string[] hireDateParts = Console.ReadLine().Split('/');

                    if (hireDateParts.Length == 3 &&
                        int.TryParse(hireDateParts[0], out int day) &&
                        int.TryParse(hireDateParts[1], out int month) &&
                        int.TryParse(hireDateParts[2], out int year))
                      
                    {
                        employees[i].Hiredate = new HireDate(year, month, day);
                        validHireDate = true;
                    }
                    else
                    {
                        Console.WriteLine("Please, enter hire date in format DD/MM/YYYY");
                    }
                }

                bool validGender = false;
                while (!validGender)
                {
                    Console.WriteLine("Enter your Gender (M for male, F for female)");
                    string genderInput = Console.ReadLine().ToLower();
                    if (genderInput == "m")
                    {
                        employees[i].GenderProp = Gender.male;
                        validGender = true;
                    }
                    else if (genderInput == "f")
                    {
                        employees[i].GenderProp = Gender.female;
                        validGender = true;
                    }
                    else
                    {
                        Console.WriteLine("Please, enter F for male or F for female");
                    }
                }
                bool validSecurityLevel = false;
                while (!validSecurityLevel)
                {
                    Console.WriteLine("Enter your SecurityLevel (guest, Developer, secretary, DBA, SecurityOfficer)");

                    if (Enum.TryParse(typeof(SecurityLevel), Console.ReadLine(), true, out object securityLevelObj))
                    {
                        employees[i].Securitylevelprop = (SecurityLevel)securityLevelObj;
                        validSecurityLevel = true;
                    }
                    else
                    {
                        Console.WriteLine("Please, enter ( guest, Developer, secretary, DBA, SecurityOfficer)");
                    }
                }
            }
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }
}
