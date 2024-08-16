using System.Security.Cryptography.X509Certificates;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mydelegate<int> d1 = new Mydelegate<int>(DeclareFunc.myfunc);
            Mydelegate<string> d2 = new Mydelegate<string>(DeclareFunc.myfunc2);
            Mydelegate<int> d3 = DeclareFunc.myfunc; //suger syntax

            //Mydelegate<string> d4 = delegate (string item)
            //{
            //    return item.Length > 5;
            //}; //using anonymous function

            Mydelegate<string> d4 = (string item) => item.Length > 5;//enhace the prevCode with goes to(arrow function) =>
            Mydelegate<string> d5 = item => item.Length > 5;//more enhance
            //Console.WriteLine(d5.Invoke("ddddddd"));

            //Console.WriteLine(d1.Invoke(1));
            //Console.WriteLine(d2.Invoke("mohsen"));

            Empdelegate empDelegate1 = new Empdelegate(DeclareFunc.myfunc3);
            Empdelegate empdelegate2 = e => e.Salary > 4000;
            Empdelegate empdelegate3 = e => e.Name.Contains('m');

            var emps = Repo.Employees;
            var emplist = DeclareFunc.FilterdByDelegate(emps, empdelegate3);
            foreach (Employee emp in emplist)
            {
                Console.WriteLine(emp);
            }

            ///momkn 27ot el arrow function 3latol
            //var emplist2 = DeclareFunc.FilterdByDelegate(emps, e => e.Salary > 4000); 
            //foreach (Employee emp in emplist2)
            //{
            //    Console.WriteLine(emp);
            //}
        }
    }
}
