
using System;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace ClientApp.Services;

public class DownloadService : IDownloadService
{
    private readonly IJSRuntime _jsRuntime;
    public DownloadService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }
    public async Task<bool> DownloadDocumet(Document document)
    {
        try
        {
            await _jsRuntime.InvokeVoidAsync(
                "downloadFromByteArray",
                new
                {
                    ByteArray = document.Data,
                    FileName = $"{document.Name}.{document.Extention}",
                    document.ContentType
                });
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }

    }
}