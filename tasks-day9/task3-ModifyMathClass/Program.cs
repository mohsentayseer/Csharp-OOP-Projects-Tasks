namespace task3_ModifyMathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            Console.WriteLine($"{a} + {b} = {MathC.Add(a, b)}");
            Console.WriteLine($"{a} - {b} = {MathC.Subtract(a, b)}");
            Console.WriteLine($"{a} * {b} = {MathC.Multiply(a, b)}");
            Console.WriteLine($"{a} / {b} = {MathC.Divide(a, b)}");
        }
    }
}
