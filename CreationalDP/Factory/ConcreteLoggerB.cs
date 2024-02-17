using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDP.Factory
{
    public class ConcreteLoggerB:ICustomLogger
    {
        public void Log()
        {
            Console.WriteLine($"log from B ");
        }
    }
}
