using System;

namespace StringsObjects
{
    class StringsObjects
    {
        static void Main()
        {
            string hi = "Hello";
            string world = "World";
            object helloword = string.Format("{0} {1}", hi, world);
            string helloall = (string)helloword;
            Console.WriteLine(helloall);
        }
    }
}
