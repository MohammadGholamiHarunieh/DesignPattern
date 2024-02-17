using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP.Visitor
{
    public class ObjectStructure
    {
        private List<IElement> elements= new List<IElement>();

        public void AddElement(IElement element)
        {
            elements.Add(element);
        }
        public void Visit(IVisitor visitor)
        {
            foreach(IElement element in elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
