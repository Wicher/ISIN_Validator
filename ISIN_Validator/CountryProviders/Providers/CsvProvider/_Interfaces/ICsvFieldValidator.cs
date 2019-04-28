using System.Collections.Generic;

namespace ISIN_Validator.CountryProviders.Providers.CsvProvider._Interfaces
{
    public interface ICsvFieldValidator
    {
        List<string[]> ValidateFields(List<string[]> fieldsList);
    }
}
