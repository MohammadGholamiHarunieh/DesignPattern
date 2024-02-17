using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP.Iterator
{
    public class ConcreteAggregate<T> : IAggregate<T>
    {
        private readonly List<T> _items;

        public ConcreteAggregate()
        {
            _items = new List<T>();
        }
        public void AddItem(T item)
        {
            _items.Add(item);
        }
        public Iterator<T> GetIterator()
        {
            return new ConcreteIterator<T>(_items); 
        }
    }
}
