using System;

namespace PrintSequense
{
    class PrintSequence
    {
        static void Main()
        {
            int a = 2;
            int b = -3;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0} {1}", a, b);
                a = a + 2;
                b = b - 2;
            }
        }
    }
}
