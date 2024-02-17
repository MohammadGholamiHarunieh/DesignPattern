using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP.Visitor
{
    public class Visitor1 : IVisitor
    {
        public void Visit(IElement element)
        {
            Console.WriteLine($"I visit {element.GetType().Name}");
        }
    }
}
