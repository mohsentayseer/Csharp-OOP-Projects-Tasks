using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Design 3D Point Class and Include the basic Constructor(s)[use chaining in constructors]
            //2.Override the ToString Function to produce this output

            //Point3D p1 = new Point3D(10,10,10);
            //Console.WriteLine(p1);
            //Console.WriteLine((string)p1);
            //////////////////////////////////////////////////////////////////////////////////////////////////
            //3. Read from the User the Coordinates for 2 point P1, P2
            //(Check the input, tryPares, Parse, Convert )
            //3 - 1 Try Array of Three Points Read and Write

            //Point3D[] PointsArr = new Point3D[2];
            //for (int i = 0; i < PointsArr.Length; i++)
            //{
            //    Console.WriteLine($"Enter Point Coordinates of {i} in format x,y,z");
            //    string[] Pointsinput = Console.ReadLine().Split(",");
            //    if (
            //    Pointsinput.Length == 3 &&
            //    int.TryParse(Pointsinput[0], out int x) &&
            //    int.TryParse(Pointsinput[1], out int y) &&
            //    int.TryParse(Pointsinput[2], out int z))

            //    {
            //    //int x = Convert.ToInt32(Pointsinput[0]);
            //    //int y = Convert.ToInt32(Pointsinput[1]);
            //    //int z = Convert.ToInt32(Pointsinput[2]);
            //        PointsArr[i] = new Point3D(x, y, z);
            //    }
            //    else
            //    {
            //        Console.WriteLine("wrong input");
            //        i = i - 1;
            //    }
            //}
            //foreach (Point3D point in PointsArr)
            //{
            //    Console.WriteLine(point);
            //}
            //////////////////////////////////////////////////////////////////////////////////////////////////
            //4.Try to use ==
            //If(P1 == P2)
            //Does it work properly? 
            //Try to override the Equals Function(from base Object)

            //Point3D p1 = new Point3D(3, 4,5);
            //Point3D p2 = new Point3D(5, 6,7);
            //Point3D p3 = new Point3D(3, 4,5);
            //Point3D p4 = p1;
            ////if (p1 == p3)
            //if (p1.Equals(p4))
            //{
            //    Console.WriteLine("EQUAL");
            //}
            //else
            //{
            //    Console.WriteLine("NOT EQUAL");
            //}
        }
    }
}
