using System;

namespace OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.WriteLine("Enter one number to check:");
            Console.WriteLine(!(int.Parse(Console.ReadLine()) % 2 == 0));
            Console.ReadLine();
        }
    }
}
