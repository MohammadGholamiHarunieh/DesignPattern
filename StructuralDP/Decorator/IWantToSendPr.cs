using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP.Decorator
{
    public class IWantToSendPr : IAction
    {
        public void Do()
        {
            Console.WriteLine("I Want To Send Pull Request :)");
        }
    }
}
