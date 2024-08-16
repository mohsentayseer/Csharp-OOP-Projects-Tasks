namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathC m = new MathC();

            int a = 10;
            int b = 5;
            Console.WriteLine($"{ a} + { b} = { m.Add(a, b)}");
            Console.WriteLine($"{ a} - { b} = { m.Subtract(a, b)}");
            Console.WriteLine($"{a} * {b} = {m.Multiply(a, b)}");
            Console.WriteLine($"{a} / {b} = {m.Divide(a, b)}");
        }
    }
}
