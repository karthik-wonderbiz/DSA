public class ValidAnagram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter first string");
        string string1 = Console.ReadLine();
        Console.WriteLine("Enter second string");
        string string2 = Console.ReadLine();
        Console.WriteLine("Valid Anagram: {0}",Anagram(string1, string2));
    }
    public static bool Anagram(string s1, string s2)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        for (int i = 0; i < s1.Length; i++) 
        {
            if (map.ContainsKey(s1[i]))
            {
                map[s1[i]]++;
            }
            else
            {
                map.Add(s1[i], 1);
            }
        }
        for (int i = 0; i < s2.Length; i++)
        {
            if (map.ContainsKey(s2[i]))
            {
                map[s2[i]]--;
            }
            else
            {
                return false;
            }
        }
        var keys = map.Keys;
        foreach (char key in keys)
        {
            if (map[key] != 0)
            {
                return false;
            }
        }
        return true;
    }
}