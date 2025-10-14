using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string term = "1";
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine($"{i}번째: {term}");
            term = Next(term);
        }
        Console.WriteLine("계속하려면 아무 키나 누르십시오 . . .");
        Console.ReadKey(true);
    }

    static string Next(string s)
    {
        var sb = new StringBuilder();
        int count = 1;
        for (int i = 1; i <= s.Length; i++)
        {
            if (i < s.Length && s[i] == s[i - 1]) count++;
            else { sb.Append(count); sb.Append(s[i - 1]); count = 1; }
        }
        return sb.ToString();
    }
}