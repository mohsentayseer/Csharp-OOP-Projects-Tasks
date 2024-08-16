using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_day6
{
    class Triangle:Shape
    {
        public Triangle(double _base,double _height):base(_base,_height)
        {}
        public double CalcArea()
        {
            return 0.5 * dim1*dim2;
        }
    }
}
