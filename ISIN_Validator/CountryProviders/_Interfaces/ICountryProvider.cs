using System.Collections.Generic;
using ISIN_Validator.CountryProviders._Enums;
using ISIN_Validator.Models;

namespace ISIN_Validator.CountryProviders._Interfaces
{
    public interface ICountryProvider
    {
        bool IsValidProvider(DataSources.Source source);

        List<IsinCountry> GetIsinCountries();
    }
}
