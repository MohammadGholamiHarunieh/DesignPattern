using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP.Composite
{
    public abstract class BaseFile
    {
        public int Size { get; set; }

        protected BaseFile(int size)
        {
           Size = size;
        }

        public abstract int CalCulateSize();
        
    }
}
