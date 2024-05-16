using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace EsercizioPasswordChainOfResponsability.Error
{
    public class ConditionNumber : Convalidator
    {
        //public override void PasswordCheck(string password)
        //{
        //    int numCount = Regex.Matches(password, @"\d").Count;

        //    if (numCount < 2)
        //    {
        //        Console.WriteLine($"{nameof(ConditionNumber)} La password deve contenere almeno 2 numeri");
        //    }
        //    else
        //        base.PasswordCheck(password);


                //}

        public override void PasswordCheck(string password)
        {
            int digitCount = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    digitCount++;
                }

            }
            if (digitCount < 2)
            {
                Console.WriteLine();
                Console.WriteLine("ERROR! The password must contain at least 2 numbers");

            }
            base.PasswordCheck(password);
        }
    }
}
