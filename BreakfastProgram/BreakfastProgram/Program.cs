using System.Threading;

namespace BreakfastProgram;

class Program
{
    static void Main(string[] args)
    {
        Thread coffeeThread = new Thread(()=> new Coffee().PourCoffee());
        Thread eggThread = new Thread(() => new Egg().CookEggs());
        Thread baconThread = new Thread(() => new Bacon().CookBacon());
        
        coffeeThread.Start();
        coffeeThread.Join();
        eggThread.Start();
        baconThread.Start();
    }
}