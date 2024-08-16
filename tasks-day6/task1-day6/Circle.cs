using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_day6
{
   class Circle:Shape
    {
        public Circle(){}
        public Circle(double _rad) : base(_rad, _rad)
        {}
        public override double CalcArea()
        {
            Console.WriteLine("iam circ");
            return Math.PI *dim1*dim2;
        }
    }
}
