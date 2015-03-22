using System;

namespace Divideby7and5
{
    class Divideby5and7
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            if (num == 0) { Console.WriteLine(false); }
            else
            {
                Console.WriteLine(num % 35 == 0);
            }
            Console.ReadLine();
        }
    }
}
