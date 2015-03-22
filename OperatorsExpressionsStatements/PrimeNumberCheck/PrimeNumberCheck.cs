using System;

namespace PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.WriteLine("Enter positive integer number between 2 and 100");
            int numberN = int.Parse(Console.ReadLine());
            while (numberN < 2 || numberN > 100)
            {
                Console.WriteLine("Try again");
                numberN = int.Parse(Console.ReadLine());
            }
            bool isPrime = true;
            int counter = 1;
   
            while (counter <= Math.Sqrt(numberN))
            {
                if (numberN % counter == 0 && counter > 1)
                {
                    isPrime = false;
                }
                counter++;
            }
            Console.WriteLine("Is your number prime?\n{0}", isPrime);
        }
    }
}
