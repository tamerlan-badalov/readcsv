
using CountryReader;

//CsvReader reader = new CsvReader(@"C:\\Users\\Tamerlan\\Desktop\\cntry.csv.txt");
CsvReader reader = new CsvReader(@"C:\Users\Tamerlan\source\repos\TestSolution\CountryReader\cntry.txt");


string? input = string.Empty;

var list = reader.ReadAllCountries().OrderBy(x => x.Name);

reader.WriteAllCountries(list);
while (input != "EXIT")
{

    input = Console.ReadLine().ToUpper();

    if (input != null) { Console.WriteLine(reader.FindCountry(input) == null ? "Cannot find" : reader.FindCountry(input)); }
}

