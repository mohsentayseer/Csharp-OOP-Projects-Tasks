using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Point
    {
        int x;
        int y;
        public void SetX(int _x) { this.x = _x; }
        public void SetY(int _y) { this.y = _y; }
        public int getX() { return this.x; }
        public int getY() { return this.y; }

        public Point()
        {
            x=y=0;
            Console.WriteLine("Point from default ctor");
        }
        public Point(int _x , int _y)
        {
            x =_x;
            y =_y;
            Console.WriteLine("Point from 2P ctor");
        }
    }
}
