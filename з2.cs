using System;

namespace лаб.раб._5_з2
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
            int k = 0;
            while (A>B)
            {
                k++;
                A -= B;
            }
            Console.WriteLine("Вывод количества отрезков В, размещённых на отрезке А:" + k);
            Console.Read();
        }
    }
}
