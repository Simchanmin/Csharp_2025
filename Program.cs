using System;

namespace Csharp_2025
{
    // 프로그램의 진입점을 포함하는 클래스
    class Program
    {
        // 프로그램 시작점: 콘솔에 "Hello World!" 출력
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    // 생성자 체이닝(Constructor Chaining)을 보여주는 예제 클래스
    class Myclass
    {
        // private 필드: 외부에서 직접 접근 불가
        int a, b, c;

        // [1번 생성자] 기본 생성자 - 매개변수 없음
        // a를 123으로 초기화
        public Myclass()
        {
            this.a = 123;  // this.a는 현재 객체의 a 필드를 의미
        }

        // [2번 생성자] 매개변수 1개 생성자
        // : this() → 먼저 위의 기본 생성자를 호출 (a=123 설정됨)
        // 그 다음 b를 매개변수 값으로 초기화
        // 실행 순서: 1번 생성자 → 2번 생성자
        public Myclass(int b) : this()
        {
            this.b = b;  // 매개변수 b를 필드 this.b에 할당
        }

        // [3번 생성자] 매개변수 2개 생성자
        // : this(b) → 먼저 위의 1개 매개변수 생성자를 호출
        //   └─ 그 생성자가 다시 기본 생성자를 호출함
        // 실행 순서: 1번 생성자 → 2번 생성자 → 3번 생성자
        // 최종 결과: a=123, b=매개변수b, c=매개변수c
        public Myclass(int b, int c) : this(b)
        {
            this.c = c;  // 매개변수 c를 필드 this.c에 할당
        }

        // 사용 예시:
        // new Myclass()        → a=123, b=0, c=0
        // new Myclass(5)       → a=123, b=5, c=0
        // new Myclass(5, 10)   → a=123, b=5, c=10
    }
}