using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Rectangle
    {
        Point ul;
        Point lr;
        public void SetUl(Point _ul) { ul = _ul; }
        public void SetLR(Point _lr) { lr = _lr; }
        public Point GetUl() { return ul; }
        public Point GetLr() { return lr; }

        public Rectangle()
        {
            ul = null;
            lr = null;
        }
        public Rectangle(Point _ul, Point _lr)
        {
            ul = _ul;
            lr = _lr;
        }
        public void DrawRect()
        {
            Console.WriteLine($"{ul.getX()},{ul.getY()} \t {lr.getX()},{lr.getY()}");
        }
    }
}
