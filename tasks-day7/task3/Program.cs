using System.Diagnostics;
using System.Linq;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region fist way(string)
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //int counter = 0;
            //for (int i = 1; i < 99999999; i++)
            //{
            //    counter += i.ToString().Split('1').Length - 1;
            //}
            //Console.WriteLine(counter);
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);
            #endregion

            #region second way(math)
            //Stopwatch sw2 = new Stopwatch();
            //sw2.Start();
            //int count = 0;
            //for (int i = 1; i <= 99999999; i++)
            //{
            //    int number = i;
            //    while (number > 0)
            //    {
            //        if (number % 10 == 1)
            //        {
            //            count++;
            //        }
            //        number /= 10;
            //    }
            //}
            //Console.WriteLine(count);
            //sw2.Stop();
            //Console.WriteLine(sw2.Elapsed);
            //int x = 21 % 10;
            //Console.WriteLine(x);
            //Console.WriteLine(21/10);

            #endregion
            #region third way(best performance)

            //Stopwatch sw3 = new Stopwatch();
            //sw3.Start();
            //int num = 99999999;
            //string stringNum = num.ToString();
            //int len = stringNum.Length;
            //double count = len * Math.Pow(10, len - 1);
            //Console.WriteLine(count);
            //sw3.Stop();
            //Console.WriteLine(sw3.Elapsed);

            #endregion
        }
    }
}
