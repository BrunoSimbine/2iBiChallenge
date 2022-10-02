using System.Text;
using ClientApp.Models;

namespace ClientApp.Services;

public class CSVService : ICSVService
{
    private StringWriter writer;
    public byte[] getAllBytesFrom(Country country)
    {
        writer = new StringWriter();
        writer.WriteLine("Common name, Native Name, Capital, Timezone, Region, Subregion, Population, Area, Flag");
        writer.WriteLine($"{country.Name?.Common}, {Helper.GetName(country)}, {country?.Capital?.First()}, {country?.Timezones?.First()}, {country?.Region}, {country?.Subregion}, {country?.Population}, {country?.Area}, {country?.Flags?.Png}");
        return Encoding.UTF8.GetBytes(writer.ToString());
    }

    public byte[] getAllBytesFrom(Country[] countries)
    {
        writer = new StringWriter();
        writer.WriteLine("Common name, Native Name, Capital, Timezone, Region, Subregion, Population, Area, Flag");
        foreach (var country in countries)
        {
            writer.WriteLine($"{country.Name?.Common}, {Helper.GetName(country)}, {country?.Capital?.First()}, {country?.Timezones?.First()}, {country?.Region}, {country?.Subregion}, {country?.Population}, {country?.Area}, {country?.Flags?.Png}");
        }
        return Encoding.UTF8.GetBytes(writer.ToString());
    }

    public Document getDocumentFrom(Country country)
    {
        return new Document()
        {
            Name = "countries",
            ContentType = "text/csv",
            Data = getAllBytesFrom(country),
            Extention = "csv"
        };
    }

    public Document getDocumentFrom(Country[] countries)
    {
        return new Document()
        {
            Name = "countries",
            ContentType = "text/csv",
            Data = getAllBytesFrom(countries),
            Extention = "csv"
        };
    }
}