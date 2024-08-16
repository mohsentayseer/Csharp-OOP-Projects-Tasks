using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Employee
    {
        int ssn;
        string name;
        int age;
        float salary;

        public void SetSsn(int _ssn)
        {
            ssn = _ssn;
        }
        public void SetName(string _name)
        {
            name = _name;
        }
        public void SetAge(int _age)
        {
            age = _age;
        }
        public void SetSalary(float _salary)
        {
            salary = _salary;
        }
        public int GetSsn()
        {
            return ssn;
        }
        public int GetAge()
        {
            return age;
        }
        public string GetName()
        {
            return name;
        }
        public float GetSalary()
        {
            return salary;
        }

        public void printV1()
        {
            Console.WriteLine($"ssn={ssn}");
            Console.WriteLine($"name={name}");
            Console.WriteLine($"age={age}");
            Console.WriteLine($"salary={salary}");
        }
        public string printV2() 
        {
            return $"{ssn}:{name}:{age}:{salary}";
        }
    }
}
