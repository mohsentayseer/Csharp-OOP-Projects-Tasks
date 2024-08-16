namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year, month, day;

            int current_day = DateTime.Now.Day;
            int current_month = DateTime.Now.Month;
            int current_year = DateTime.Now.Year;
            do
            {
                Console.WriteLine("enter your year from 1980->2023");
                year = int.Parse(Console.ReadLine());
            }
            while (year < 1979 || year > 2024);
            do
            {
                Console.WriteLine("enter your month");
                month = int.Parse(Console.ReadLine());
            }
            while (month < 1 || month > 12);

            if (month == 2)
                if (month == 2 && year % 4 == 0)
                {
                    do
                    {
                        Console.WriteLine("enter your day leap-feb");
                        day = int.Parse(Console.ReadLine());
                    }
                    while (day < 1 || day > 29);
                }
                else
                {
                    do
                    {
                        Console.WriteLine("enter your day not-leap-feb");
                        day = int.Parse(Console.ReadLine());
                    }
                    while (day < 1 || day > 28);
                }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {

                do
                {
                    Console.WriteLine("enter your day 4-6-9-11");
                    day = int.Parse(Console.ReadLine());
                }
                while (day < 1 || day > 30);
            }

            else
            {
                do
                {
                    Console.WriteLine("enter your day s7");
                    day = int.Parse(Console.ReadLine());
                }
                while (day < 1 || day > 31);
            }

            int age_years = current_year - year;
            int age_months = current_month - month;
            int age_days = current_day - day;
            if (age_days < 0) {
                age_months -= 1;
                age_days += DateTime.DaysInMonth(current_year, current_month - 1);
            }
            if (age_months < 0) {
                age_years -= 1;
                age_months += 12;
                    }
            Console.WriteLine($"you're {age_years}y {age_months}months {age_days}days");

            Console.ReadKey();
        }
    }
}
