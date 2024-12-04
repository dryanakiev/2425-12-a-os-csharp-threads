namespace UserInterrupt;

class Something
{
    public void DoWork()
    {
        while (true)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name}: Working...");
            Thread.Sleep(1000);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.Name = "Main Thread";

        Console.WriteLine(Thread.CurrentThread.Name);

        Thread somethingThread = new Thread(() => new Something().DoWork());
        
        somethingThread.Name = "Something Thread";
        
        // Set somethingThread as a daemon property
        somethingThread.IsBackground = true;
        
        somethingThread.Start();

        while (somethingThread.IsAlive)
        {
        }
    }
}