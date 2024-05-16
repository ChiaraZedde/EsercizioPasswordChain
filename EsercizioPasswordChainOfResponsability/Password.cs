using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioPasswordChainOfResponsability
{
    internal class Password :Convalidator
    {
        private string _password;
        public Password (string password)
        {
           _password = password;
        }
        public void PasswordCondition()
        {
            Console.WriteLine("Inserisci una password per vedere se è scritta correttamente: ");
           
            Next.PasswordCheck(_password);
            

        }
    }
    }



