namespace ClientApp.Services;

public class Document
{
    public string? Name { get; set; }
    public string? Extention { get; set; }
    public string? ContentType { get; set; }
    public byte[]? Data { get; set; }
}