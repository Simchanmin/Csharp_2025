using System;
using System.Collections.Generic;

class NumberSearch
{
    static void Main()
    {
        Console.Write("정수의 갯수와 찾고자 하는 수를 공백으로 구분하여 입력: ");
        string? header = Console.ReadLine();
        if (header is null) return;

        string[] first = header.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        if (first.Length < 2 || !int.TryParse(first[0], out int n) || !int.TryParse(first[1], out int target) || n <= 0)
        {
            Console.WriteLine("형식: [정수 개수(양수)] [찾을 수]");
            return;
        }

        var values = new List<int>(n);
        while (values.Count < n)
        {
            string? line = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(line)) continue; // 엔터만 입력하면 다시 입력받음

            foreach (var tok in line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (int.TryParse(tok, out int v))
                {
                    values.Add(v);
                    if (values.Count == n) break;
                }
            }
        }

        if (values.Count < n)
        {
            Console.WriteLine($"정수 {n}개가 필요합니다. 현재 {values.Count}개만 입력되었습니다.");
            return;
        }

        int idx = values.IndexOf(target);
        if (idx >= 0)
            Console.WriteLine($"찾는 수 {target}의 순서번호={idx + 1}");
        else
            Console.WriteLine($"찾는 수 {target}는 배열에 없습니다.");

        Console.WriteLine("계속하려면 아무 키나 누르십시오...");
        Console.ReadKey(true);
    }
}