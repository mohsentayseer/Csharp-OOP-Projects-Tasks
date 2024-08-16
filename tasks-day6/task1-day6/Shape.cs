using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_day6
{
   abstract class Shape
    {
       protected double dim1;
        protected double dim2;
        protected void SetDim1(double _dim1) { dim1 = _dim1; }
        protected void SetDim2(double _dim2) { dim2 = _dim2; }
        public double GetDim1 () { return dim1; }
        public double GetDim2() { return dim2; }

        public Shape()
        {
            dim1 = dim2 = 0;
        }
        public Shape(double _dim1 , double _dim2)
        {
            dim1 = _dim1;
            dim2 = _dim2;
        }
        public virtual double CalcArea()
        {
            Console.WriteLine("iam shape");
            return -1;
        }


    }

}
