using System;

namespace Lesson1
{
    class Program
    { 
        static void Main(string[] args)
        { 
             Numeric numeric = new Numeric();
             numeric.Primenumberornot(Convert.ToDouble(Console.ReadLine()));
        }


    }
}
