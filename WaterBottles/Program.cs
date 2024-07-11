public class WaterBottles
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number of Bottles: ");
        int numBottles = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the number of Bottles required to Exchange: ");
        int numExchage = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The total amount of bottles that can be drank: {0}", DrinkableBottles(numBottles, numExchage));
    }
    public static int DrinkableBottles(int numBottles, int numExchange)
    {
        int drinkable = numBottles;
        int drinkExchange;
        int bottlesLeft;
        while (numBottles >= numExchange) 
        {
            drinkExchange = numBottles / numExchange;
            bottlesLeft = numBottles % numExchange;
            numBottles = bottlesLeft + drinkExchange;
            drinkable += drinkExchange;
        }
        return drinkable;
    }
}