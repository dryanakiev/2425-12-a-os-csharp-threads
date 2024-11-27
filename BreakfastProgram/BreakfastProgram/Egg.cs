namespace BreakfastProgram;

public class Egg
{
    public void CookEggs()
    {
        Console.WriteLine("Cooking eggs...");
        Thread.Sleep(12000);
        Console.WriteLine("Egg cooked!");
        Thread.Sleep(1000);
    }
}