using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shootingTime
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество выстрелов:\t");
            int shoot = int.Parse(Console.ReadLine());
            int point = 0;
            for (int i = 0; i < shoot; i++)
            {
                Console.Write($"Введите координаты х и y {i + 1} выстрела в следующих строках:\n");
                int x = int.Parse(Console.ReadLine()); int y = int.Parse(Console.ReadLine());
                if (Math.Abs(x) <= 1 && Math.Abs(y) <= 1) point = point + 10;
                else if (Math.Abs(x) <= 2 && Math.Abs(y) <= 2) point = point + 5;
            }
            Console.WriteLine("Your result is " + point);
        }
    }
}

