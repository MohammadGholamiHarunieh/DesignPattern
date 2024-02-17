using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP.Mediator
{
    public abstract class Colleague
    {
        protected readonly IMediaor _mediaor;

        public Colleague(IMediaor mediaor)
        {
            _mediaor = mediaor;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
