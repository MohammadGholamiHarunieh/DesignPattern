using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP.Composite
{
    public class File : BaseFile
    {
        public File(int size) : base(size)
        {
        }

        public override int CalCulateSize()
        {
            return this.Size;
        }
    }
}
