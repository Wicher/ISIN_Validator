using System.Collections.Generic;
using System.Linq;
using ISIN_Validator.CountryProviders._Enums;
using ISIN_Validator.CountryProviders._Interfaces;

namespace ISIN_Validator.CountryProviders.Factories
{
    public class CountryProviderFactory : ICountryProviderFactory
    {
        private readonly IEnumerable<ICountryProvider> _providerList;

        public CountryProviderFactory(IEnumerable<ICountryProvider> providerList)
        {
            _providerList = providerList;
        }

        public ICountryProvider GetProvider(DataSources.Source dataSource)
        {
            return _providerList.Single(x => x.IsValidProvider(dataSource));
        }
    }
}
