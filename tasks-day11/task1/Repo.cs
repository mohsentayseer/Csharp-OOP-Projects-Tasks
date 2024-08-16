using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public static class Repo
    {
        static List<Employee> employees;
        public static List<Employee> Employees
        {
            get
            {
                return new List<Employee>()
                {
                    new Employee{Id=1,Name="Ziad",Age=22,Salary=2000,DeptId=10},
                    new Employee{Id=2,Name="Sara",Age=23,Salary=3000,DeptId=20},
                    new Employee{Id=3,Name="Osama",Age=22,Salary=4000,DeptId=20},
                    new Employee{Id=4,Name="Aya",Age=25,Salary=9000,DeptId=30},
                    new Employee{Id=5,Name="Ali",Age=24,Salary=12000,DeptId=10},
                    new Employee{Id=6,Name="Saeed",Age=29,Salary=4000,DeptId=10},
                    new Employee{Id=7,Name="Mahmoud",Age=28,Salary=5000,DeptId=10},
                    new Employee{Id=8,Name="Mohamed",Age=27,Salary=6000,DeptId=20},
                    new Employee{Id=9,Name="Reham",Age=26,Salary=7000,DeptId=20},
                    new Employee{Id=10,Name="Lara",Age=30,Salary=8000,DeptId=10},
                };
            }
        }
    }
}
