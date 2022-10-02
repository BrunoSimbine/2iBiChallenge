namespace ClientApp.Models;

public class Country
{
    public Name? Name { get; set; }
    public List<string>? Capital { get; set; }
    public string? Region { get; set; }
    public string? Subregion { get; set; }
    public double Area { get; set; }
    public int Population { get; set; }
    public List<string>? Timezones { get; set; }
    public Flag? Flags { get; set; }
}