using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EsercizioPasswordChainOfResponsability.Error
{
    public class ConditionLenght : Convalidator
    {
        public override void PasswordCheck (string password)
        {
            if (password.Length < 8)
            {
                Console.WriteLine($"{nameof(ConditionLenght)} La password deve essere lunga almeno 8 caratteri");
            }
            
                base.PasswordCheck(password);


        }
        
    }
}
