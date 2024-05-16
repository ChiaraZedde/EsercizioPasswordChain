using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace EsercizioPasswordChainOfResponsability.Error
{

    public class ConditionMaiusc : Convalidator
    {

        public override void PasswordCheck(string password)
        {

            bool UpperPresence = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                {
                    UpperPresence = true;
                    break;
                }
            }

                if (!UpperPresence)
                {
                    Console.WriteLine($"{nameof(ConditionMaiusc)} La password deve contenere almeno una lettera maiuscola");
                }
               
                    base.PasswordCheck(password);


            
        }
    }

}
