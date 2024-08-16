using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public delegate bool Mydelegate<T>(T _item);
    public delegate bool Empdelegate(Employee e);
    public delegate bool TwoparmasDelegate<T>(T x, T y);
    public delegate U SpecialOutDelegate< T, U>(T x, T y);
    public delegate U SpecialOutDelegate2<in T,out U>(T x,T y);
    internal static class DeclareFunc
    {
        public static bool myfunc(int x)
        {
            return x > 5;
        }
        public static bool myfunc2(string x)
        {
            return x.Length > 5;
        }
        public static bool myfunc3(Employee e)
        {
            return e.DeptId ==10;
        }
        public static List<Employee> FilterdByDelegate(List<Employee> list1, Empdelegate empdelegate1)
        {
            List<Employee> result = new List<Employee>();

            foreach (Employee emp in list1)
            {
                if (empdelegate1(emp))
                {
                    result.Add(emp);
                }
            }
                return result;
        }
    }
}
