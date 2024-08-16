namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex c1, c2, c3;
            c1 = new Complex();
            c2 = new Complex();
            c3 = new Complex();
            Console.WriteLine(Complex.counter);
            //for testing!
            //while (true)
            //{
            //    c1.setReal(int.Parse(Console.ReadLine()));
            //    c1.setImg(int.Parse(Console.ReadLine()));
            //    Console.WriteLine(c1.Print());
            //}

            Console.WriteLine("enter c2.real");
            c2.setReal(int.Parse(Console.ReadLine()));
            Console.WriteLine("enter c2.img");
            c2.setImg(int.Parse(Console.ReadLine()));

            //c3 = c1.Add(c1, c2);
            c3 = c1.Add(c2);
            Console.WriteLine(c3.Print());

        }
    }
}
