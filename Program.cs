using System;

namespace homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double h;
            double m;
            Console.WriteLine("Введите свой рост в метрах");
            string str = Console.ReadLine();
            h = Convert.ToDouble(str);
            Console.WriteLine("Введите свой вес в килограммах");
            m = Convert.ToDouble(Console.ReadLine());
            double i = m / (h + h);
            Console.WriteLine(i);
        }
    }
}