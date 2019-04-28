using System;
using ISIN_Validator.Configuration._Interfaces;
using ISIN_Validator.CountryProviders._Enums;
using ISIN_Validator.CountryProviders._Interfaces;
using ISIN_Validator.Dependencies;

namespace IsinChecker
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var container = new DependencyFactory();

            var providerFactory = container.Resolve<ICountryProviderFactory>();

            var provider = providerFactory.GetProvider(DataSources.Source.Csv);

            var countryList = provider.GetIsinCountries();
            foreach (var country in countryList)
            {
                Console.WriteLine(country);
            }
            Console.ReadLine();
        }
    }
}
