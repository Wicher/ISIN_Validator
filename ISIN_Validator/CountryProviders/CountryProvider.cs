using System.Collections.Generic;
using ISIN_Validator.CountryProviders._Interfaces;
using ISIN_Validator.Models;
using ISIN_Validator._Enums;

namespace ISIN_Validator.CountryProviders
{
    public abstract class CountryProvider : ICountryProvider
    {
        protected DataSources.Source DataSource { get; }

        protected CountryProvider(DataSources.Source dataSource)
        {
            DataSource = dataSource;
        }

        public bool IsValidProvider(DataSources.Source source)
        {
            return DataSource == source;
        }

        public abstract List<IsinCountry> GetIsinCountries();
    }
}
