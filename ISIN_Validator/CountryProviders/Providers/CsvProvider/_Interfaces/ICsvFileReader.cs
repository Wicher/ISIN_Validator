using System.Collections.Generic;

namespace ISIN_Validator.CountryProviders.Providers.CsvProvider._Interfaces
{
    public interface ICsvFileReader
    {
        List<string[]> ReadFields();
    }
}
