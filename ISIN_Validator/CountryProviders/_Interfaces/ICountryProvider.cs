using System.Collections.Generic;
using ISIN_Validator.Models;
using ISIN_Validator._Enums;

namespace ISIN_Validator.CountryProviders._Interfaces
{
    public interface ICountryProvider
    {
        bool IsValidProvider(DataSources.Source source);

        List<IsinCountry> GetIsinCountries();
    }
}
