using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EsercizioPasswordChainOfResponsability.Error
{
    internal class ConditionSpechChar : Convalidator
    {
        public override void PasswordCheck(string password)
        {
            bool specialChar = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    specialChar = true;
                    break;
                }
            }
            if (!specialChar)
            {
                Console.WriteLine();
                Console.WriteLine("La password deve contenere almeno un carattere speciale");
            }
        


    }
    }
}
