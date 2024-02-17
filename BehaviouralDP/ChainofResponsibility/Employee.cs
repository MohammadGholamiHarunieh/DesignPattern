using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP.ChainofResponsibility
{
    public class Employee : Signer
    {
        public override void Sign()
        {
            Console.WriteLine("Employee sign it.");
            Console.WriteLine("I'm the last person in the chain :).");
            
        }
    }
}
