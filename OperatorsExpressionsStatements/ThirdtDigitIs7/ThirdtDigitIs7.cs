using System;

namespace ThirdtDigitIs7
{
    class ThirdtDigitIs7
    {
        static void Main()
        {
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine(i / 100 % 10 == 7);
            Console.ReadLine();
        }
    }
}
