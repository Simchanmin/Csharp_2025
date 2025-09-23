// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        int score = 0;
        int english = 0;
        int physics = 0;
        int calculus = 0;
        int average = 0;
        String name = "";
        String department = "";
        Console.Write("이름을 입력하세요:");
        name = Console.ReadLine();
        Console.Write("학과를 입력하세요:");
        department = Console.ReadLine();
        Console.Write("영어 점수를 입력하세요:");
        english = Convert.ToInt32(Console.ReadLine());
        Console.Write("물리학 점수를 입력하세요:");
        physics = Convert.ToInt32(Console.ReadLine());
        Console.Write("미적분학 점수를 입력하세요:");
        calculus = Convert.ToInt32(Console.ReadLine());
        Console.Write("주소를 입력하세요:");
        String address = Console.ReadLine();
        score = english + physics + calculus;
        average = score / 4;
        Console.WriteLine("이름 = "+name+", 학과명 = "+department);
        Console.WriteLine("영어 = "+english+", 물리학 + "+physics+", 미적분학 = "+calculus);
        Console.WriteLine("총점 = "+score+", 평균 = "+ average);
        Console.WriteLine("주소 = "+address);

    }
}