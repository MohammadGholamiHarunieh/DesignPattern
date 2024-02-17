using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP.Proxy
{
    public class DbRepository : IRepository
    {
        public void Get()
        {
            Console.WriteLine("Hello From Db");
        }

    }
}
