using ClientApp.Models;

namespace ClientApp.Services;

public interface IConverterService
{
    byte[] getAllBytesFrom(Country country);
    byte[] getAllBytesFrom(Country[] countries);
    
    Document getDocumentFrom(Country country);
    Document getDocumentFrom(Country[] countries);
}