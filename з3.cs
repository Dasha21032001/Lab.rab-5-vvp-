using System;

namespace лаб.раб_5_з3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            Console.WriteLine("введите A: ");// Ввод A
            A = Convert.ToInt32(Console.ReadLine());// Вывод A
            Console.WriteLine("введите B: ");// Ввод B
            B = Convert.ToInt32(Console.ReadLine());// Вывод B
            while (A > B)
            {
                int k = 0;
                k++;
                A = A - B;
                }
            Console.WriteLine("Длина незанятой части А: " + A);
            Console.Read();

        }
    }
}
