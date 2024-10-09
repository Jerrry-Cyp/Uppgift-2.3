using System;

namespace Uppgift_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar vill du hyra bil?");
            int hyrdagar = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många kilometer vill du köra?");
            int kilometer = int.Parse(Console.ReadLine());
            Console.WriteLine("Detta kommer kosta " + (300 + hyrdagar * 500 + kilometer) + "kr");
        }
    }
}