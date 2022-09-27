using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryReader
{
    public class CsvReader
    {
        private string _filePath;

        private List<Country> _countries;
        public CsvReader(string filePath)
        {
            this._filePath = filePath;
        }
        public Country? FindCountry(string country)
        {
            if (country.Length != 2) return null;

            return  _countries.Find(x=>x.CountryAbr == country);
        }
        public List<Country> ReadAllCountries() 
        {
        List<Country> countries = new List<Country>();

            using ( StreamReader sr = new StreamReader(_filePath))
            {
                sr.ReadLine();

                string? csv;
                while ((csv = sr.ReadLine()) != null)
                {
                    countries.Add(ReadCountryFromCsv(csv));
                }

            }
            _countries = countries;
            return countries;
        }
        public void WriteAllCountries(IEnumerable<Country> countries) 
        {
            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }

        }

        public Country ReadCountryFromCsv(string csvLine)
        {
            var a = csvLine.Split(',');
            return new Country(a[0], a[3]);
        }
    }
}
