using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP.Strategy
{
    public class EMAStrategy : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Open order Using EMA strategy");
        }
    }
}
