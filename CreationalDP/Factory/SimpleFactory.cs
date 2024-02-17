using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDP.Factory
{
    public class SimpleFactory
    {
        public string Name { get; set; }
        public string Family { get; set; }

        public string Phone { get; set; }
        private SimpleFactory(string? name,string? family,string? phone) 
        {
            Name = name;
            Family = family;
            Phone = phone;
        }

        public static SimpleFactory CreatePersonWithBrifData(string name, string family) => new SimpleFactory(name, family,null);
        public static SimpleFactory CreatePersonWithFullData(string name, string family,string phone) => new SimpleFactory(name, family,phone);
        
    }

    public class SimpleFactory2
    {
        public string Name { get; set; }
        public string Family { get; set; }

        public string Phone { get; set; }
        private SimpleFactory2(string name, string family)
        {
            Name = name;
            Family = family;
        }
        private SimpleFactory2(string name, string family, string phone)
        {
            Name = name;
            Family = family;
            Phone = phone;
        }

        public static SimpleFactory2 CreatePersonWithBrifData(string name, string family) => new SimpleFactory2(name, family);
        public static SimpleFactory2 CreatePersonWithFullData(string name, string family, string phone) => new SimpleFactory2(name, family, phone);

    }
}
