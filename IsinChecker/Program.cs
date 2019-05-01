using System;
using ISIN_Validator.Configuration._Interfaces;
using ISIN_Validator.CountryProviders._Interfaces;
using ISIN_Validator.Dependencies;
using ISIN_Validator._Enums;

namespace IsinChecker
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var container = new DependencyFactory();

            var provider = container.Resolve<ICountryProviderFactory>()
                .GetProvider(DataSources.Source.Csv);

            var countryList = provider.GetIsinCountries();
            foreach (var country in countryList)
            {
                Console.WriteLine(country);
            }
            Console.ReadLine();
        }
    }
}
