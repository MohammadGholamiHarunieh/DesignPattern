using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP.Adapter
{
    public class Adapter : Target
    {
        private readonly Adaptee _daptee;
        public Adapter(Adaptee adaptee)
        {
                _daptee = adaptee;
        }
        public void CustomerWants()
        {
            _daptee.GiveCustomerWhatHeWants();
        }
    }
}
