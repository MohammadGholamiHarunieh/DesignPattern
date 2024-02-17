using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDP.Factory
{
    public abstract class CustomLoggerAbstractFactory
    {
        public abstract ICustomLogger CreateCustomLogger();

        public void Log()
        {
            var logger = CreateCustomLogger();
            logger.Log();
        }
    }
}
