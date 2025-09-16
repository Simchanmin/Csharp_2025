// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {

        int num = 7;
        String? str = num.ToString();
        Console.WriteLine("str={0}", str);
        Console.WriteLine("str{0}", str.GetType());
        String? val = Convert.ToString(num);
        Console.WriteLine("val={0}", val);
        int score = 0;
        Console.Write("점수입력=");
        switch(Console.ReadLine())
        {
            case "A":
                score = 100;
                break;
            case "B":
                score = 80;
                break;
            case "C":
                score = 70;
                break;
            default:
                score = 60;
                break;
        }

        Console.WriteLine("점수={0}", score);
    }
}