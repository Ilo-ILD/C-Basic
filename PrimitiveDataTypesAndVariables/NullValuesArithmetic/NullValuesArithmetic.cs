using System;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? nullableInteger = null;
            double? floatNumber = null;
            Console.WriteLine("Null value: " + nullableInteger);
            Console.WriteLine("Null value: " + floatNumber);

            nullableInteger += 12;
            floatNumber += 3.75;
            Console.WriteLine("Number + null value: " + nullableInteger);
            Console.WriteLine("Number + null value: " + floatNumber);

            nullableInteger = 12;
            floatNumber = 3.75;
            Console.WriteLine("Number value: " + nullableInteger);
            Console.WriteLine("Number value: " + floatNumber);
        }
    }
}
