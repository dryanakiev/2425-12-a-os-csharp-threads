namespace BreakfastProgram;

public class Coffee
{
    public void PourCoffee()
    {
        Console.WriteLine("Pouring coffee...");
        Thread.Sleep(5000);
        Console.WriteLine("Coffee poured!");
        Thread.Sleep(1000);
    }
}