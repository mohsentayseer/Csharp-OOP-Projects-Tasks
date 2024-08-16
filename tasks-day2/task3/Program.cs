namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 22, 3, 43, 53, 33, 88, 85 };
            int searchNum;
            bool found = false;
            while (!found)
            {
                Console.WriteLine("enter number");
                searchNum = int.Parse(Console.ReadLine());
                found = false;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (searchNum == arr[i])
                    {
                        Console.WriteLine($"index of number {arr[i]} is {i}");
                        found = true;
                        break;
                    }
                }
                    if (!found)
                    {
                        Console.WriteLine("not found");
                    }
            }
        }
    }
}