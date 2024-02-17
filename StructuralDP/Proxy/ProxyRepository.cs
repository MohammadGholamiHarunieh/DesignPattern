using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP.Proxy
{
    public class ProxyRepository : IRepository
    {
        private readonly IRepository _repository;
        public ProxyRepository()
        {
            _repository=new DbRepository();
        }
        public void Get()
        {
            if (_repository==null)
            {
                Console.WriteLine("Hello From Cache");
            }
            _repository.Get();
            
        }
    }
}
