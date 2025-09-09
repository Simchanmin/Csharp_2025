using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp250902
{
    internal class Hello
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Hello, World!");
            Console.WriteLine(8 / 5);
            Console.WriteLine("8/5={0}",
                                8 / 5);
            Console.WriteLine("8%5={0}",
                                8 % 5);
            Console.WriteLine(
                "-4 % 3={0}", (-4 % 3) );
            Console.WriteLine(
                "4 % -3={0}", (4 % -3));
            Console.WriteLine(
                "-4 % -3={0}", (-4 % -3));

            Console.WriteLine(1.0 + 2.0);
            Console.WriteLine(1.0 - 2.0);
            Console.WriteLine(1.0 * 2.0);
            Console.WriteLine(1.0 / 2.0);

            Console.WriteLine(
       "5.0 % 2.2={0}", (5.0 % 2.2));
            Console.WriteLine(
        "This is\t\t a\n \"string\"");

        }
    }
}
