using System;

namespace QuotesStrings
{
    class QuotesStrings
    {
        static void Main()
        {
            string whit = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(whit);
            string whitout = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(whitout);
        }
    }
}
