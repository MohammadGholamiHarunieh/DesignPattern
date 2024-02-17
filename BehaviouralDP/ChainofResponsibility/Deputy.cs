using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP.ChainofResponsibility
{
    public class Deputy : Signer
    {
        public override void Sign()
        {
            Console.WriteLine("Deputy sign it.");
            _nextSigner.Sign();
        }
    }
}
