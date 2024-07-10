public class KrishnamoorthyNo
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        int sum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            int prod = 1;
            int fact = 1;
            for (int j = 1; j <= (input[i] - '0'); j++)
            {
                fact = j * prod;
                prod = fact;
            }
            sum += prod;
        }

        if (sum == Convert.ToInt32(input))
        {
            Console.WriteLine("The entered number is a Krishnamoorthy number.");
        }
        else
        {
            Console.WriteLine("The entered number is not a Krishnamoorthy number.");
        }
    }
}