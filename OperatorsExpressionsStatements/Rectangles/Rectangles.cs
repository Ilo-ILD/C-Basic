using System;

namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            Console.WriteLine("width?");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("height?");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Area={0}, Perimeter={1}", 2 * height + 2 * width, width * height);
            Console.Read();
        }
    }
}
