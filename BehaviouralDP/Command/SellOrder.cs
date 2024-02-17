using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP.Command
{
    public class SellOrder : ICommand
    {
        public SellOrder(int amount)
        {
            Amount = amount;
        }
        public int Amount { get; set; }

        public void Execute()
        {
            Console.WriteLine($"sell order with amount {Amount} created.");
        }
    }
}
