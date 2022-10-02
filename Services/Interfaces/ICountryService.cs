using ClientApp.Models;

namespace ClientApp.Services;

public interface ICountryService
{
    Task<Country[]?> GetCountries();
    Task<Country[]?> SearchCountriesByName(string name);
    Task<Country?> GetCountry(string Name);
}