using System.Text;
using System.Xml;
using System.Xml.Serialization;
using ClientApp.Models;

namespace ClientApp.Services;

public class XMLService : IXMLService
{
    private XmlSerializer xsSubmit;
    public byte[] getAllBytesFrom(Country country)
    {
        xsSubmit = new XmlSerializer(typeof(Country));
        using var sww = new StringWriter();
        using var writer = XmlWriter.Create(sww);
        xsSubmit.Serialize(writer, country);
        return Encoding.UTF8.GetBytes(sww.ToString());
    }

    public byte[] getAllBytesFrom(Country[] countries)
    {
        
        xsSubmit = new XmlSerializer(typeof(Country[]));
        using var sww = new StringWriter();
        using var writer = XmlWriter.Create(sww);
        xsSubmit.Serialize(writer, countries);
        return Encoding.UTF8.GetBytes(sww.ToString());
    }

    public Document getDocumentFrom(Country country)
    {
        return new Document()
        {
            Name = "countries",
            ContentType = "text/xml",
            Data = getAllBytesFrom(country),
            Extention = "xml"
        };
    }

    public Document getDocumentFrom(Country[] countries)
    {
        return new Document()
        {
            Name = "countries",
            ContentType = "text/xml",
            Data = getAllBytesFrom(countries),
            Extention = "xml"
        };
    }
}