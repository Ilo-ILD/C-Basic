using System;

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            Console.WriteLine("Enter coordinate x of the point");
            decimal pointX = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of the point");
            decimal pointY = decimal.Parse(Console.ReadLine());
            byte radius = 2;
            
            bool isInCircle = pointX * pointX + pointY * pointY <= radius * radius;
            Console.WriteLine("Is the given point in the circle?\n{0}", isInCircle);
        }
    }
}
