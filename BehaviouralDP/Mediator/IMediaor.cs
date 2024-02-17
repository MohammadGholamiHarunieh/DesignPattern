using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP.Mediator
{
    public interface IMediaor
    {
        void Send(Colleague from,string message);
    }
}
