using System;

namespace AgeAfter10Years
{
    class AgeAfter10
    {
        static void Main()
        {
            Console.WriteLine("Write your Birthday (day.month.year)");
            DateTime yourBirthDay = DateTime.Parse(Console.ReadLine());
            DateTime timeNow = DateTime.Today;
            int currentAge = 0;
            if (yourBirthDay.Month >= timeNow.Month && yourBirthDay.Day >= timeNow.Day)
            {
                currentAge = timeNow.Year - yourBirthDay.Year - 1;
                Console.WriteLine("After 10 years you will be: {0}", currentAge + 10);
                Console.WriteLine("But now you are: {0}", currentAge);
            }
            else
            {
                currentAge = timeNow.Year - yourBirthDay.Year;
                Console.WriteLine("After then years you will be: {0}", currentAge + 10);
                Console.WriteLine("But now you are: {0}", currentAge);
            }
        }
    }
}