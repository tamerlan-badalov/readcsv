using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryReader 
{
    public class Country
    {
        public string CountryAbr { get; set; }
        public string Name { get; set; }

        public Country(string CountryAbr, string Name)
        {
            this.CountryAbr = CountryAbr;
            this.Name = Name;
        }

        public override string ToString() => $"{Name} {CountryAbr}";
    }
}
