using ClientApp.Models;
using OfficeOpenXml;

namespace ClientApp.Services;

public class XLSService : IXLSService
{

    public XLSService()
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
    }
    public byte[] getAllBytesFrom(Country country)
    {
        using ExcelPackage package = new ExcelPackage();
        var workSheet = package.Workbook.Worksheets.Add("country");

        workSheet.Cells[1, 1].Value = "Common Name";
        workSheet.Cells[1, 2].Value = "Native Name";
        workSheet.Cells[1, 3].Value = "Capital";
        workSheet.Cells[1, 4].Value = "Region";
        workSheet.Cells[1, 5].Value = "Subregion";
        workSheet.Cells[1, 6].Value = "Population";
        workSheet.Cells[1, 7].Value = "Area";
        workSheet.Cells[1, 8].Value = "Timezone";
        workSheet.Cells[1, 9].Value = "Flag";

        workSheet.Cells[2, 1].Value = country.Name?.Common;
        workSheet.Cells[2, 2].Value = Helper.GetName(country);
        workSheet.Cells[2, 3].Value = country.Capital?.FirstOrDefault();
        workSheet.Cells[2, 4].Value = country.Region;
        workSheet.Cells[2, 5].Value = country.Subregion;
        workSheet.Cells[2, 6].Value = country.Population;
        workSheet.Cells[2, 7].Value = country.Area;
        workSheet.Cells[2, 8].Value = country.Timezones?.FirstOrDefault();
        workSheet.Cells[2, 9].Value = country.Flags?.Png;

        return package.GetAsByteArray();
    }

    public byte[] getAllBytesFrom(Country[] countries)
    {
        using ExcelPackage package = new ExcelPackage();
        var workSheet = package.Workbook.Worksheets.Add("country");

        workSheet.Cells[1, 1].Value = "Common Name";
        workSheet.Cells[1, 2].Value = "Native Name";
        workSheet.Cells[1, 3].Value = "Capital";
        workSheet.Cells[1, 4].Value = "Region";
        workSheet.Cells[1, 5].Value = "Subregion";
        workSheet.Cells[1, 6].Value = "Population";
        workSheet.Cells[1, 7].Value = "Area";
        workSheet.Cells[1, 8].Value = "Timezone";
        workSheet.Cells[1, 9].Value = "Flag";

        int i = 2;
        foreach (var country in countries)
        {
            workSheet.Cells[i, 1].Value = country.Name?.Common;
            workSheet.Cells[i, 2].Value = Helper.GetName(country);
            workSheet.Cells[i, 3].Value = country.Capital?.FirstOrDefault();
            workSheet.Cells[i, 4].Value = country.Region;
            workSheet.Cells[i, 5].Value = country.Subregion;
            workSheet.Cells[i, 6].Value = country.Population;
            workSheet.Cells[i, 7].Value = country.Area;
            workSheet.Cells[i, 8].Value = country.Timezones?.FirstOrDefault();
            workSheet.Cells[i, 9].Value = country.Flags?.Png;

            i++;
        }

        return package.GetAsByteArray();
    }

    public Document getDocumentFrom(Country country)
    {
        return new Document()
        {
            Name = "country",
            ContentType = "application/vnd.ms-excel",
            Data = getAllBytesFrom(country),
            Extention = "xls"
        };
    }

    public Document getDocumentFrom(Country[] countries)
    {
        return new Document()
        {
            Name = "countries",
            ContentType = "application/vnd.ms-excel",
            Data = getAllBytesFrom(countries),
            Extention = "xls"
        };
    }
}