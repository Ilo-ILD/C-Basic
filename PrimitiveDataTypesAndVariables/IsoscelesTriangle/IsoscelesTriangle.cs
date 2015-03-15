using System;
using System.Text;

namespace IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main()
        {
            string ch1 = "";       
            char cCc = '\u00A9';
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("{0} {1} {2} {3} {4} ", ch1, ch1, ch1, ch1, cCc);
            Console.WriteLine("{0} {1} {2} {3} {4} ", ch1, ch1, ch1, cCc, cCc);
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", ch1, ch1, cCc, ch1, ch1, cCc);
            Console.WriteLine("{0} {1} {2} {3} {4}", ch1, cCc, cCc, cCc, cCc);
        }
    }   //  Console.WriteLine("{0,4}\n{0,3}{0,2}\n{0,2}{0,4}\n{0}{0,2}{0,2}{0,2}", cCc);
}       //  Console.WriteLine@"   cCc
        //                     cCc   cCc
       //                     cCc     cCc
       //                    cCc  cCc  cCc"
