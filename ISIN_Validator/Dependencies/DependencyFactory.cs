using ISIN_Validator.Configuration;
using ISIN_Validator.Configuration.Helpers;
using ISIN_Validator.Configuration.Helpers._Interfaces;
using ISIN_Validator.Configuration._Interfaces;
using ISIN_Validator.CountryProviders.Factories;
using ISIN_Validator.CountryProviders.Providers;
using ISIN_Validator.CountryProviders.Providers.CsvProvider;
using ISIN_Validator.CountryProviders.Providers.CsvProvider._Interfaces;
using ISIN_Validator.CountryProviders._Interfaces;
using ISIN_Validator._Enums;
using Unity;
using Unity.Lifetime;

namespace ISIN_Validator.Dependencies
{
    public class DependencyFactory
    {
        public static IUnityContainer Container;

        static DependencyFactory()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IConfigurationProvider, ConfigurationProvider>(
                new ContainerControlledLifetimeManager());
            container.RegisterType<IConfigurationFileReader, ConfigurationFileReader>(
                new ContainerControlledLifetimeManager());
            container.RegisterType<IConfigurationFileParser, ConfigurationFileParser>(
                new ContainerControlledLifetimeManager());

            container.RegisterType<ICountryProviderFactory, CountryProviderFactory>();
            container.RegisterType<ICountryProvider, CsvCountryProvider>(DataSources.Source.Csv.ToString());
            container.RegisterType<ICountryProvider, DatabaseCountryProvider>(DataSources.Source.Database.ToString());
            container.RegisterType<ICountryProvider, WebCountryProvider>(DataSources.Source.Web.ToString());

            container.RegisterType<ICsvFileReader, CsvFileReader>();
            container.RegisterType<ICsvFieldValidator, CsvFieldValidator>();
            container.RegisterType<ICsvFieldParser, CsvFieldParser>();
            Container = container;
        }

        public T Resolve<T>()
        {
            var entity = default(T);
            if (Container.IsRegistered(typeof(T)))
            {
                entity = Container.Resolve<T>();
            }
            return entity;
        }
    }
}
