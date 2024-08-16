namespace task1_day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(3,4);
            //Console.WriteLine("rec Area= "+r1.CalcArea());

            Square s1 = new Square(10);
            //Console.WriteLine("sqr Area= " + s1.CalcArea());

            Triangle t1 = new Triangle(5, 7);
            //Console.WriteLine("tri Area= " + t1.CalcArea());

            Circle c1 = new Circle(5);  
            //Console.WriteLine("circ Area= " + c1.CalcArea());

            //Shape shape1 = new Rectangle(3,4);
            Shape[] shapes = {r1,s1,t1,c1 };
            Console.WriteLine(Utility.SumOfAreasV2(shapes));// 3nde so2al: leh by3ml call llfunction bt3et elshape w leh eltrteb el8areeb dah
        }
    }
}
