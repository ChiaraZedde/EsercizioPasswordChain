using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioPasswordChainOfResponsability
{
    public abstract class Convalidator
    {
        protected Convalidator Next;

 

        //public abstract void Process(int password);



        public Convalidator SetSuccesor(Convalidator nextCheck)
        {
            Next = nextCheck;
            return Next;
        }
        public virtual void PasswordCheck(string password)
        {
            Next.PasswordCheck(password);
        }
        //public virtual void SetSuccessor(string password)
        //{
        //    Next?.SetSuccessor(password);
        //    //Console.WriteLine(password);
        //}
    }
}
