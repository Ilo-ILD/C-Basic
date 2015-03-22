using System;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            int number = 0;
            Console.Write("Enter a integer between 1000 and 9999: ");

            if (int.TryParse(Console.ReadLine(), out number) && number >= 1000 && number <= 9999) 
            {
                Console.Clear();
                int firstDigit = number / 1000;
                int secondDigit = ((number / 100) % 10);
                int thirdDigit = ((number / 10) % 10);
                int fourDigit = number % 10;

                int digitsSum = firstDigit + secondDigit + thirdDigit + fourDigit;
                string reversed = fourDigit.ToString() + thirdDigit.ToString() + secondDigit.ToString() + firstDigit.ToString();
                string lastInFront = fourDigit.ToString() + firstDigit.ToString() + secondDigit.ToString() + thirdDigit.ToString();
                string exchangedDigids = firstDigit.ToString() + thirdDigit.ToString() + secondDigit.ToString() + fourDigit.ToString();

                Console.WriteLine("n\tsum\treversed\tlast in front\texchanged digits"); 
                Console.WriteLine("{0}\t{1}\t{2}\t\t{3}\t\t{4}", number, digitsSum, reversed, lastInFront, exchangedDigids);
            }
            else
            {
                Console.WriteLine("You have entered invalid data!");
            }
        }
    }
}
