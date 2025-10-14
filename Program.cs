using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("첫 번째 배열의 숫자들을 공백으로 구분하여 입력하세요:");
        string? input1 = Console.ReadLine();
        Console.WriteLine("두 번째 배열의 숫자들을 공백으로 구분하여 입력하세요:");
        string? input2 = Console.ReadLine();

        int[] array1 = input1.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                             .Select(int.Parse)
                             .ToArray();

        int[] array2 = input2.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                             .Select(int.Parse)
                             .ToArray();

        Console.WriteLine("\n첫 번째 배열:");
        Console.WriteLine("{ " + string.Join(" ", array1) + " }");

        Console.WriteLine("두 번째 배열:");
        Console.WriteLine("{ " + string.Join(" ", array2) + " }");


        int[] mergedArray = array1.Concat(array2).ToArray();
        Array.Sort(mergedArray);

        Console.WriteLine("\n합쳐서 정렬한 결과:");
        Console.WriteLine("{ " + string.Join(" ", mergedArray) + " }");

        Console.WriteLine();
        Console.WriteLine("계속하려면 아무 키나 누르십시오 . . .");
        Console.ReadKey(true);
    }
}