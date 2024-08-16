namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "this is a string";
            Console.WriteLine(String.Join(" ", input.Split(" ").Reverse()));
        }
    }
}