namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Line l1 = new Line();

            //Line l2 = new Line(1, 2, 3, 4);
            //l2.DrawLine();

            Point p1 = new Point(3, 4);
            Point p2 = new Point(5, 6);
            Rectangle r1 = new Rectangle();
            
            //Rectangle r2 = new Rectangle(null, null);
            //r2.SetUl(p1);
            //r2.SetUl(p2);//solution for build relationship

            Rectangle r2 = new Rectangle(p1,p2);//another solution for build relationship
            r2.DrawRect();
            ////cancel relationship
            //r2.SetUl(null);
            //r2.SetLR(null);
        }
    }
}
