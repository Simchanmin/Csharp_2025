// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {

        int age = 0;
        string name = null;
        char blood = '\0'; // null 문자로 초기화
        Console.Write("나이 입력: ");
        age = int.Parse(Console.ReadLine());
        Console.WriteLine("나이: {0}", age);


    }
}