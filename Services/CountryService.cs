using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ClientApp.Models;
using Newtonsoft.Json;

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
        var request = await _httpClient.GetAsync(new Uri("https://restcountries.com/v3.1/all"));
        var data = await request.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<Country[]>(data);
    }
    
    public async Task<Country[]?> SearchCountriesByName(string? name)
    {
        var countries = await GetCountries();
        return name == null ? countries : countries?.ToList().FindAll(x => x.Name?.Common != null && x.Name != null && x.Name.Common.Contains(name)).ToArray();
    }

    public async Task<Country?> GetCountry(string Name)
    {
        var countries = await GetCountries();
        Console.WriteLine("Message");
        return countries?.First(x => x.Name?.Common == Name);
    }
}