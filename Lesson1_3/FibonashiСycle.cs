using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_3
{
    public class FibonashiСycle
    {
        public int Fibinashi(int n)
        {

            

            int[] fibinashi = new int[n];
            fibinashi[0] = 0;
            fibinashi[1] = 1;
            Console.WriteLine(fibinashi[0]);
            Console.WriteLine(fibinashi[1]);
            for (int i = 2; i < n; i++)
            {
                // F(N) = F(N - 2) + F(N - 1).
                fibinashi[i] = fibinashi[i - 2] + fibinashi[i - 1];
                Console.WriteLine(fibinashi[i]);

            }
            return fibinashi[0];
        }

        public FibonashiСycle()
        {

        }


    }
}
