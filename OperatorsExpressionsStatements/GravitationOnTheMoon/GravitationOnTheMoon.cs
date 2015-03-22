using System;

namespace GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.WriteLine("Your weight?");
            Console.WriteLine(double.Parse(Console.ReadLine()) / 100 * 17 + "<---This is your weight on the Moon");
            Console.ReadLine();
        }
    }
}
