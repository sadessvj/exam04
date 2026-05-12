using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите сторону a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите сторону b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите сторону c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Треугольник является равносторонним.");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Треугольник является равнобедренным.");
            }
            else
            {
                Console.WriteLine("Треугольник является разносторонним.");
            }
        }
        else
        {
            Console.WriteLine("Треугольник с такими сторонами не существует.");
        }
    }
}
