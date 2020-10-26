using System;
using static System.Math;

namespace Laborotornaya_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ФИО:Плотников Федор Сергеевич, Группа:ИУ5-31Б");
            Console.WriteLine("Введите коэффициенты биквадратного уравнения");
            int A, B, C;
            double D;
            string s;
            s = Console.ReadLine();
            A = int.Parse(s);
            if (A is 0)
            {
                Console.WriteLine("Введите число A, не равное 0");
                s = Console.ReadLine();
                A = int.Parse(s);
            }
            s = Console.ReadLine();
            B = int.Parse(s);
            s = Console.ReadLine();
            C = int.Parse(s);
            D = B * B - 4 * A * C;
            if(D is 0)
            {
                double x1;
                x1 = -B / (2 * A);
                if (x1 < 0)
                    D = -1;
                if (x1 > 0)
                {
                    x1 = Math.Sqrt(x1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("x1={0},x2={1}", x1, -x1);
                    Console.ResetColor();
                }
            }
            if (D > 0)
            {
                double x1, x2;
                x1 = (-B + Math.Sqrt(D)) / (2 * A);
                if (x1 > 0)
                {
                    x1 = Math.Sqrt(x1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("x1={0:F1},x2={1:F1}", x1, -x1);
                    Console.ResetColor();
                }
                x2 = (-B - Math.Sqrt(D)) / (2 * A);
                if (x2 > 0)
                {
                    x2 = Math.Sqrt(x2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("x3={0:F1},x4={1:F1}", x2, -x2);
                    Console.ResetColor();
                }
                if (x1 < 0 && x2 < 0)
                    D = -1;
            }
            if (D < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("КОРНЕЙ НЕТ");
                Console.ResetColor();
            }
        }
    }
}
