namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FTP fTP1 = FTP.Ftp;
            FTP fTP2 = FTP.Ftp;
            Console.WriteLine(fTP1.test);
            Console.WriteLine(fTP2.test);
            Console.WriteLine(fTP1.GetHashCode());
            Console.WriteLine(fTP2.GetHashCode());
        }
    }
}
