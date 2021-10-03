using System;

public class FibonashiRecursion
{
    public FibonashiRecursion()
    {
    }


    public void Fibonashi(int fib1, int fib2, int fibn, int fibi)
    {
        if (fibi < fibn)
        {
            int fibonashi = fib1 + fib2;
            Console.WriteLine(fibonashi);
            fibi += 1;

            Fibonashi(fib2, fibonashi, fibn, fibi);

        }

    }
}
