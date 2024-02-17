using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP.ChainofResponsibility
{
    public abstract class Signer
    {
        protected Signer _nextSigner;
        
        public void SetNextSigner(Signer nextsigner)
        {
            _nextSigner= nextsigner;
        }
        public abstract void Sign();
    }
}
