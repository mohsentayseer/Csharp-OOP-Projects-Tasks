using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_day6
{
    class Square : Shape
    {
        public Square() { }
        public Square(double _dim) : base(_dim, _dim) { }
        public override double CalcArea()
        {
            Console.WriteLine("iam sqr");
            return dim1 * dim2;
        }

    }
    class SquareV2 : Shape
    {
        public SquareV2() { }
        public SquareV2(double _dim) : base(_dim, _dim) { }
    }
}
