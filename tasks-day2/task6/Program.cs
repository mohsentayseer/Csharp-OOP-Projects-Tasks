namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2;
            string _operator;
            char ans;
            do
            {
                Console.WriteLine("enter num1");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("enter num2");
                num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("enter operator (+ & - & * & /)");
                _operator = (Console.ReadLine());
                while (_operator != "+" && _operator != "-" && _operator != "*" && _operator != "/")
                {
                    Console.WriteLine("please, enter operator (+ & - & * & /)");
                    _operator = (Console.ReadLine());
                }
                switch (_operator)
                {
                    case "+":
                        Console.WriteLine($"{num1}+{num2}={num1 + num2}");
                        break;
                    case "-":
                        Console.WriteLine($"{num1}-{num2}={num1 - num2}");
                        break;
                    case "*":
                        Console.WriteLine($"{num1}*{num2}={num1 * num2}");
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Math error");
                        }
                        else
                        {
                            Console.WriteLine($"{num1}/{num2}={num1 / num2}");
                        }
                        break;
                }
                Console.WriteLine("continue y or n?");
                ans = char.Parse(Console.ReadLine());
            } while (ans == 'y');
            Console.ReadKey();
        }
    }
}
