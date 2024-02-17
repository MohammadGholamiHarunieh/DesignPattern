using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP.Strategy
{
    public class Trade
    {
        private readonly IStrategy strategy;

        public Trade(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void OpenOrder()
        {
            strategy.Execute();
        }
    }
}
