using System;

namespace InsideCircleOutsideRectangle
{
    class InsideCircleOutsideRectangle
    {
        static void Main()
        {
            Console.WriteLine("Enter coordinate x of the point");
            decimal pointX = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of the point");
            decimal pointY = decimal.Parse(Console.ReadLine());
            decimal radius = 1.5m;
            
            bool isInCircle = (pointX - 1) * (pointX - 1) + (pointY - 1) * (pointY - 1) <= radius * radius;
        
            if (isInCircle && pointY > 1)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
