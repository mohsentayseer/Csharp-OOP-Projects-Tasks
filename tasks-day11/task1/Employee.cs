using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
        public int DeptId { get; set; }

        //public Employee(){}
        //public Employee(int _id, string _name, int age, decimal salary ,int dept_id)
        //{
        //    Name = _name;
        //    Id = _id;
        //    Salary = salary;
        //    Age = age;
        //    DeptId = dept_id;
        //}
        public override string ToString()
        {
            return $"id= {Id} \t EmpName= {Name}";
        }
    }
}
