using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP.Decorator
{
    public class IShouldCheckItBefore : IAction
    {
        private readonly IAction _action;

        public IShouldCheckItBefore(IAction action)
        {
            _action = action;
        }
        public void Do()
        {
            Console.WriteLine("I Should CheckIt Before :|");
            _action.Do();
        }
    }
}
