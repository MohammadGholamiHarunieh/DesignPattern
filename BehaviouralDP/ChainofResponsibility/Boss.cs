using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP.ChainofResponsibility
{
    public class Boss : Signer
    {
        public override void Sign()
        {
            Console.WriteLine("Boss sign it.");
            _nextSigner.Sign();
        }
    }
}
