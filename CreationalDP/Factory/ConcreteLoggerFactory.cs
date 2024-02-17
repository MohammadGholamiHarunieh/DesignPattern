using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDP.Factory
{
    public class ConcreteLoggerFactoryA : CustomLoggerAbstractFactory
    {
        public override ICustomLogger CreateCustomLogger()
        {
            return new ConcreteLoggerA();
        }
    }

    public class ConcreteLoggerFactoryB : CustomLoggerAbstractFactory
    {
        public override ICustomLogger CreateCustomLogger()
        {
            return new ConcreteLoggerB();
        }
    }
}
