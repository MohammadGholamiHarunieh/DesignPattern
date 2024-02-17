using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP.Mediator
{
    public class ConcreteMediator : IMediaor
    {
        private ConcreteColleague1 _concreteColleague1;
        private ConcreteColleague2 _concreteColleague2;
        public void SetConcreteColleague1(ConcreteColleague1 concreteColleague1)
        {
            _concreteColleague1 = concreteColleague1;
        }

        public void SetConcreteColleague2(ConcreteColleague2 concreteColleague2)
        {
            _concreteColleague2 = concreteColleague2;
        }
        public void Send(Colleague from, string message)
        {
            if (from is ConcreteColleague1) 
            {
                _concreteColleague2.Receive(message);
            }
            else if (from is ConcreteColleague2)
            {
                _concreteColleague1.Receive(message);
            }
            else
            {
                throw new Exception("Colleague Not Found");
            }
        }
    }
}
