using System;

namespace Lesson1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ФибоначчиЦикл");
            Console.WriteLine("Введите число:");
            FibonashiСycle fibonashi = new FibonashiСycle();
            fibonashi.Fibinashi(Convert.ToInt32(Console.ReadLine()));
           
            
            Console.WriteLine("ФибоначчиРекурсия");
            Console.WriteLine("Введите число:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(0);
            Console.WriteLine(1);

            if (n == 0)
            {
                Console.WriteLine($"Число должно быть больше {n}");
            }

            FibonashiRecursion fibonashiRecursion = new FibonashiRecursion();
            fibonashiRecursion.Fibonashi(0, 1, n - 2, 0);
           
        }


    }
}

