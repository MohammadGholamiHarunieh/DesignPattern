using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP.FlyWeight
{
    public class AlphabetFactory
    {
        private Dictionary<string, IAlphabet> _alphabets = new();

        public IAlphabet GetAlphabet(string key)
        {
            if (!_alphabets.ContainsKey(key))
            {
                this._alphabets[key]=new Alphabet(key);
            }
            return _alphabets[key];
        }
    }
}
