using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP.Composite
{
    public class Folder : BaseFile
    {
        private List<BaseFile> _moadels;

        public IReadOnlyList<BaseFile> MoadelList => _moadels.AsReadOnly();
        public Folder(int average) : base(average)
        {
            _moadels = new List<BaseFile>();
        }

        public override int CalCulateSize()
        {
            var classmoadel = 0;
            foreach (var moadel in _moadels)
            {

                classmoadel += moadel.CalCulateSize();

            }
            return classmoadel;
        }

        public void Add(BaseFile x)
        {
            _moadels.Add(x);
        }
        public void Remove(BaseFile x)
        {
            _moadels.Remove(x);
        }
    }
}
