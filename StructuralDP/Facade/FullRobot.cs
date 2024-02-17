using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP.Facade
{
    public class FullRobot
    {
        void IShop() { Console.WriteLine("I Shop"); }

        void IPay() { Console.WriteLine("I pay"); }

        void IClean() { Console.WriteLine("I clean"); }

        void ICoock() { Console.WriteLine("I cook"); }

        void IExcercise() { Console.WriteLine("I exercise"); }
    }
}
