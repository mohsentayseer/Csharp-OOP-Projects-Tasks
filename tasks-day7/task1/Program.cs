namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 0 };
            //int[] arr = { 1,1,1,1,1,1,1};
            int maxSpace = 1;
            int space;
            for (int i = 0; i < arr.Length - 1; i++)
            {

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        space = j - i - 1;
                        if (maxSpace < space)
                        {
                            maxSpace = space;
                        }
                    }
                }
                space = 0;
            }
            Console.WriteLine($"\t max space= {maxSpace}");
        }
    }
}
