namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bubble sort
            int[] arr = { 2, 1, 6, 3, 4, 0, 5, 7 };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(arr[i] +" ");
            }
        }
    }
}
