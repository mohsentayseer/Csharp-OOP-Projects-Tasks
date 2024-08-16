namespace task3_circularQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CircularQueue q1 = new CircularQueue();
            q1.Enqueue(10);
            q1.Enqueue(20);
            q1.Enqueue(30);
            q1.Display();
            Console.WriteLine("Peek: " + q1.Peek());
            q1.Dequeue();
            q1.Display();
            Console.WriteLine("Peek: " + q1.Peek());
            q1.Enqueue(40);
            q1.Display();
            q1.Dequeue();
            q1.Display();
            q1.Enqueue(50);
            q1.Enqueue(60);
            q1.Enqueue(70);
            q1.Display();
            q1.Enqueue(100);
            q1.Display();
            Console.WriteLine("Peek: " + q1.Peek());
        }
    }
}
