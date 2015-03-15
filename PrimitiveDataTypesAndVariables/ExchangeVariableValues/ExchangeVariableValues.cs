using System;

namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("A: {0}", a);
            Console.WriteLine("B: {0}", b);
            int tempnew = a;
            a = b;
            b = tempnew;
            Console.WriteLine("A: {0}", a);
            Console.WriteLine("B: {0}", b);
        }
    }
}
