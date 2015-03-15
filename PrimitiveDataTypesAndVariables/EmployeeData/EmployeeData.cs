using System;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string FirstN, LastN;
            sbyte Age;
            char Gender;
            long PersonID;
            ulong UnigueEmpID;
            FirstN = "Petko";
            LastN = "Dimitrov";
            Age = 32;
            Gender = 'm';
            PersonID = 8306112507;
            UnigueEmpID = 275600027569999;
            Console.WriteLine("First Name:" + FirstN + "Last Name:" + LastN + "Age:" + Age + "Gender:" + Gender + "PersonalID" + PersonID + "Unige Employee ID:" + UnigueEmpID);

            FirstN = "Katia";
            LastN = "Grigorova";
            Age = 27;
            Gender = 'f';
            PersonID = 7206112507;
            UnigueEmpID = 275600027569923;
            Console.WriteLine("First Name:" + FirstN + "Last Name:" + LastN + "Age:" + Age + "Gender:" + Gender + "PersonalID" + PersonID + "Unige Employee ID:" + UnigueEmpID);
        }
    }
}
