using System;

namespace HexaDecimal
{
    class HexaDecimal
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Your number in Hex is: {0:X}", num);
        }
    }
}
