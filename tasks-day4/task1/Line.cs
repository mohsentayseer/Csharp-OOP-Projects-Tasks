using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Line
    {
        Point start;//Point as field 
        Point end;
        public void SetStart(Point _start) { start = _start; }
        public void SetEnd(Point _end) { end = _end; }
        public Point GetStart() { return start; }
        public Point GetEnd() { return end; }
        public Line()
        {
            start = new Point();//obj from Point (call point ctor)
            end = new Point();
            //start.SetX(0);//l2n l1 hyd5ol 3la el ctor bta3 Point w hwa 3ndo initialization  
            //start.SetY(0);
            //end.SetX(0);
            //end.SetY(0);
            Console.WriteLine("Line from default ctor");
        }
        public Line(int x1,int y1,int x2,int y2)
        {
            start = new Point();
            end = new Point();
            start.SetX(x1);
            start.SetY(y1);
            end.SetX(x2);
            end.SetY(y2);
            Console.WriteLine("Line 4P ctor");
        }
        public void DrawLine()
        {
            Console.WriteLine($"start({start.getX()},{start.getY()}) \t end({end.getX()},{end.getY()})");
        }
    }

}
