using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        BigInteger temp, first = 1, second = 2;
        for (int i = 0; i < 100; i++)
        {
            if (i == 0) Console.WriteLine(i);
            else if (i == 1)
            {
                Console.WriteLine(i);
                Console.WriteLine(i); Console.WriteLine(i + 1);
            }
            else
            {
                temp = first + second;
                Console.WriteLine(temp);
                first = second;
                second = temp;
            }
        }
    }
}
