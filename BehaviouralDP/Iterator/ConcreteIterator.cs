using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP.Iterator
{
    public class ConcreteIterator<T> : Iterator<T>
    {
        public readonly List<T> _items;
        private int _index=0;
        public ConcreteIterator(List<T> items)
        {
            _items = items;
        }
        public T Current()
        {
            return _items[_index];
        }

        public T First()
        {
           return _items[0];
        }

        public bool HasNext()
        {
          return  _index < _items.Count()-1;
        }

        public T Next()
        {
            if (HasNext())
            {
                _index++;
                return _items[_index];
            }
            return default(T);
        }
    }
}
