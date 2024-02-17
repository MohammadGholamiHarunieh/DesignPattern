using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP.Mediator
{
    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(IMediaor mediaor) : base(mediaor)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"ConcreteColleague2: I recieved message '{message}' from ConcreteColleague1");
        }

        public override void Send(string message)
        {
            _mediaor.Send(this, message);
        }
    }
}
