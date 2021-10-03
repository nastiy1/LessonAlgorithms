using System;

public class Numeric
{
   
    public int d=0;
    public int i=2;

    public double Primenumberornot(double number)
    {


        while (i < number)
        {
            if (number % i == 0)
            {
                d++;
            }
            i++;

        }

        if (d == 0)
        {
            Console.WriteLine("Простое");
        }
        else
        {
            Console.WriteLine("не простое");
        }

        return number;
    }

    public Numeric()
    {

    }
}


