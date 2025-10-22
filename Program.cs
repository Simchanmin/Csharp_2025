using System;

class Car
{
    private int speed;
    private int number;
    private string carname;
    private string addr;
    private string carcolor;
    private int upspeed;
    private int downspeed;

    public Car(int speed, int number, string carname, string addr, string carcolor)
    {
        this.speed = speed;
        this.number = number;
        this.carname = carname;
        this.addr = addr;
        this.carcolor = carcolor;
        this.upspeed = 0;
        this.downspeed = 0;
    }

    public void InputSpeed()
    {
        Console.Write("차의 속도를 입력: ");
        this.speed = int.Parse(Console.ReadLine());
    }

    public void InputNumber()
    {
        Console.Write("차의 넘버를 입력: ");
        this.number = int.Parse(Console.ReadLine());
    }

    public void InputCarname()
    {
        Console.Write("차의 이름을 입력: ");
        this.carname = Console.ReadLine();
    }

    public void InputAddr()
    {
        Console.Write("차 운전자의 주소를 입력: ");
        this.addr = Console.ReadLine();
    }

    public void InputCarcolor()
    {
        Console.Write("차의 색깔을 입력: ");
        this.carcolor = Console.ReadLine();
    }

    public void PrintInfo()
    {
        Console.WriteLine($"speed={this.speed}");
        Console.WriteLine($"number={this.number}");
        Console.WriteLine($"carname={this.carname}");
        Console.WriteLine($"addr={this.addr}");
        Console.WriteLine($"carcolor={this.carcolor}");
    }

    public void UpSpeed()
    {
        Console.Write("증가시킬 차의 속도 입력: ");
        this.upspeed = int.Parse(Console.ReadLine());
        this.speed += this.upspeed;
        Console.WriteLine($"증가된 차의 속도={this.speed}");
    }

    public void DownSpeed()
    {
        Console.Write("감소시킬 차의 속도 입력: ");
        this.downspeed = int.Parse(Console.ReadLine());
        this.speed -= this.downspeed;
        Console.WriteLine($"감소된 차의 속도 = {this.speed}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car(0, 0, "", "", "");

        myCar.InputSpeed();
        myCar.InputNumber();
        myCar.InputCarname();
        myCar.InputAddr();
        myCar.InputCarcolor();
        myCar.PrintInfo();
        myCar.UpSpeed();
        myCar.UpSpeed();
        myCar.DownSpeed();

        Console.WriteLine("계속하려면 아무 키나 누르십시오 . . .");
        Console.ReadKey(true);
    }
}