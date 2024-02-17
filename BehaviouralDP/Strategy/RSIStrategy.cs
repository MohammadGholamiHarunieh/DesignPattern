using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP.Strategy
{
    public class RSIStrategy : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Open order Using RSI strategy");
        }
    }
}
