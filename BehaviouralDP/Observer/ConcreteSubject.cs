using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP.Observer
{
    public class ConcreteSubject : ISubject
    {
        List<IObserver> _observers=new ();
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(string message)
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(message);
            }
        }
    }
}
