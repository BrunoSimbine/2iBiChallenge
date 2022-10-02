using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ClientApp.Models;

namespace ClientApp.Services;

public class CountryService : ICountryService
{
    private readonly HttpClient _httpClient;
    public CountryService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<Country[]?> GetCountries()
    {
        return await _httpClient.GetFromJsonAsync<Country[]>("sample-data/countries.json");
    }
    
    public async Task<Country[]?> SearchCountriesByName(string? name)
    {
        var countries = await _httpClient.GetFromJsonAsync<Country[]>("sample-data/countries.json");
        return name == null ? countries : countries?.ToList().FindAll(x => x.Name?.Common != null && x.Name != null && x.Name.Common.Contains(name)).ToArray();
    }

    public async Task<Country?> GetCountry(string Name)
    {
        var countries = await _httpClient.GetFromJsonAsync<Country[]>("sample-data/countries.json");
        return countries?.FirstOrDefault(x => x.Name?.Common == Name);
    }
}