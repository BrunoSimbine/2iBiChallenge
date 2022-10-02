namespace ClientApp.Services;

public interface IDownloadService
{ 
    Task<bool> DownloadDocumet(Document document);
}