using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP.FlyWeight
{
    public interface IAlphabet
    {
        string Print();
    }

    public class Alphabet : IAlphabet
    {
        public string Name { get; set; }
        public Alphabet(string name)
        {
            Name = name;
        }
        public  string Print()
        {
            return Name;
        }
    }
}
