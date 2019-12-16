using System;

namespace лаб.раб__5_з5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите трёхзначное число");
            a = Convert.ToInt32(Console.ReadLine());//вывод трехзначного числа
            int b = a % 100;
            int c = a / 100;
            Console.WriteLine("Вывод изменённого а:" + b + c);
            Console.ReadLine();
        }
    }
}
