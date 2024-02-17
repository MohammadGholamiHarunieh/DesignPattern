using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP.Iterator
{
    public interface Iterator<T>
    {
        public T First();

        public T Next();
        public bool HasNext();
        public T Current();
    }
}
