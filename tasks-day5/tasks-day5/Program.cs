namespace tasks_day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDynamicStack s2 = new MyDynamicStack(7);
            s2.Push(10);
            s2.Push(20);
            s2.Push(30);
            s2.Push(40);
            s2.Push(50);
            s2.Push(60);
            s2.Push(70);
            s2.Push(80);

            Console.WriteLine(s2.Pop());
            Console.WriteLine(s2.Pop());
            Console.WriteLine(s2.Pop());
            Console.WriteLine(s2.Pop());
            Console.WriteLine(s2.Pop());
            Console.WriteLine(s2.Pop());
            Console.WriteLine(s2.Pop());
            Console.WriteLine(s2.Pop());
        }
    }
}
