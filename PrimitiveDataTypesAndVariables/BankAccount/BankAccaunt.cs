using System;

namespace BankAccount
{
    class BankAccaunt
    {
        static void Main()
        {
            string firstName = "Dimcho";
            string middleName = "Ivanov";
            string lastName = "Ivanov";
            decimal money = 3943850.20m;
            string bankName = "Haspa";
            string iban = "BG32 UBBS 7827 1013 6179 05";
            long cardNumber1 = 568456789123509;
            long cardNumber2 = 908768932123456;
            long cardNumber3 = 574834523456789;
            Console.WriteLine("{0} {1} {2}\nAvailable amount of money: {3}\n{4} IBAN: {5}\nCard number: {6}\nCard number: {7}\nCard number: {8}", firstName, middleName, lastName, money, bankName, iban, cardNumber1, cardNumber2, cardNumber3);
        }
    }
}
