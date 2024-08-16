using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_day6
{
    class Rectangle:Shape
    {
        public Rectangle(){}
        public Rectangle(double _dim1,double _dim2):base(_dim1,_dim2){}
        public override double CalcArea()
        {
            Console.WriteLine("iam rec");
            return dim1 * dim2;
        }
    }
}
