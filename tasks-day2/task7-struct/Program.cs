namespace task7_struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region create one employee
            //Employee e1;                      //(like var x) //24B in mem //all data are unassigned (didn't have default values) output=>error"unassigned"
            //e1 = new Employee();             //new+struct =>fields initialization ONLYY (had default values) output=>0
            ////e1.ssn = 312; // this line make line "e1 = new Employee()" less important because i can directly put initial values for e1

            //Console.WriteLine("enter you ssn");
            //e1.ssn = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter you name");
            //e1.name = Console.ReadLine();
            //Console.WriteLine("enter you age");
            //e1.age = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter you salary");
            //e1.salary = int.Parse(Console.ReadLine());

            //Console.WriteLine($"hello {e1.name}");
            //Console.WriteLine(e1.ssn);
            //Console.WriteLine(e1.age);
            //Console.WriteLine(e1.salary);
            #endregion

            Employee[] employees;
            employees = new Employee[3];//new+array => allocation im mem and initialization 

        }
    }
}
