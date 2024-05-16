using EsercizioPasswordChainOfResponsability.Error;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;


namespace EsercizioPasswordChainOfResponsability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Password password = new Password("ciaopassword48L@");
            var conditionLenght = new ConditionLenght();
            var conditionMaiusc = new ConditionMaiusc();
            var conditionNumber = new ConditionNumber();
            var conditionSpechChar = new ConditionSpechChar();



            

            password
                .SetSuccesor(conditionLenght)
                .SetSuccesor(conditionMaiusc)
                .SetSuccesor(conditionNumber)
                .SetSuccesor(conditionSpechChar);
            password.PasswordCondition();



         
        }
       
        }

}