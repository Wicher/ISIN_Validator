using ISIN_Validator.CountryProviders._Enums;

namespace ISIN_Validator.CountryProviders._Interfaces
{
    public interface ICountryProviderFactory
    {
        ICountryProvider GetProvider(DataSources.Source dataSource);
    }
}
