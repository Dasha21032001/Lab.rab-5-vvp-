using System;

namespace лаб.раб__5_з1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("введите число байтов: ");// Ввод a
            a = Convert.ToInt32(Console.ReadLine());// Вывод a
            b = (int) (a / 1024);//количество полных килобайтов
            Console.WriteLine("Вывод количества полных килобайтов" + b);
            Console.Read();
        }
    }
}
