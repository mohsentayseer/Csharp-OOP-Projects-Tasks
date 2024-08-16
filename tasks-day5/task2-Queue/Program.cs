namespace task2_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q1 = new Queue();
            q1.Display();
            q1.Enqueue(10);
            q1.Enqueue(20);
            q1.Enqueue(30);
            q1.Enqueue(40);
            q1.Enqueue(50);
            q1.Display();
            q1.Enqueue(60);
            q1.Display();
            Console.WriteLine("Peek "+q1.Peek());
            q1.Display();
            q1.Dequeue();
            q1.Display();
            q1.Enqueue(90);
            q1.Display();
            Console.WriteLine("Peek " + q1.Peek());



        }
    }
}