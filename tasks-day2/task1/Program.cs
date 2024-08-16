namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 6, 3, 4, 0, -5, 7, 100, 9, 10, 11, 12, 88, 14, 34 };
            int max = arr[0];
            int min = arr[0];

            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"Maximum number : {max}");
            Console.WriteLine($"Minimum number : {min}");
        }
    }
}
