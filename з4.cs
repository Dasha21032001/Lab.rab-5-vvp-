using System;

namespace лаб.раб__5_з4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите двузначное число");
            a = Convert.ToInt32(Console.ReadLine());//вывод двузначного числа
            int b = a % 10;
            int c = a / 10;
            Console.WriteLine("Вывод изменённого а:" + b+c);
            Console.ReadLine();
        }
    }
}
