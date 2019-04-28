using System.Collections.Generic;
using ISIN_Validator.Models;

namespace ISIN_Validator.CountryProviders.Providers.CsvProvider._Interfaces
{
    public interface ICsvFieldParser
    {
        List<IsinCountry> ParseFields(List<string[]> fieldsList);
    }
}
