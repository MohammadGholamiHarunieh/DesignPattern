using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP.Observer
{
    public class ConcreteObserver2 : IObserver
    {
        public string State { get; private set; }

        public void SetState(string state)
        {
            State = state;
            Console.WriteLine($"observer 2 state sets to {State}");
        }
        public void Update(string message)
        {
            State = message;
            Console.WriteLine($"observer 2 state Changes to {State} base on recived message from subject");
        }
    }
}
