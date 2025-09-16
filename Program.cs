// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Console.Write("이름을 입력해주세요: ");
        string name = Console.ReadLine();
        Console.Write("점수를 입력해주세요: ");
        int score = int.Parse(Console.ReadLine());
        switch (score)
        {
            case >= 90:
                Console.WriteLine($"{name}님의 학점은 A입니다.");
                break;
            case >= 80:
                Console.WriteLine($"{name}님의 학점은 B입니다.");
                break;
            case >= 70:
                Console.WriteLine($"{name}님의 학점은 C입니다.");
                break;
            case >= 60:
                Console.WriteLine($"{name}님의 학점은 D입니다.");
                break;
            default:
                Console.WriteLine($"{name}님의 학점은 F입니다.");
                break;
        }
    }
}