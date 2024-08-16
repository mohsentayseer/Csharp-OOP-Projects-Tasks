using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_day6
{
   class Utility
    {
        public static double SumOfAreasV1(Rectangle _rec, Square _sqr, Triangle _tri)
        {
            double sum = 0;
            sum += _rec.CalcArea();
            sum += _sqr.CalcArea();
            sum += _tri.CalcArea();
            return sum;
        }
        public static double SumOfAreasV2(Shape[] _shapes)
        {
            double sum = 0;
            for (int i = 0; i < _shapes.Length; i++)
            {
                sum += _shapes[i].CalcArea();
            }
            return sum;
        }

    }
}
