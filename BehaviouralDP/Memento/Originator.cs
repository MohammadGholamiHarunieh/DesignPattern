using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP.Memento
{
    public class Originator
    {
        private string state;
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                Console.WriteLine($"state set to '{value}'");
                state = value;
            }
        } 

        public Memento CreteSnapshot()
        {
            Console.WriteLine($"Snapshot is taken with value {State}");
            return new Memento(State);
        }

        public void Undo(Memento memento)
        {
            State = memento.State;
            Console.WriteLine($"Undo to previous state with value {State} done.");
        }
        
    }
}
