using System;
using System.Collections.Generic;
using ISIN_Validator.Models;
using ISIN_Validator._Enums;

namespace ISIN_Validator.CountryProviders.Providers
{
    public class DatabaseCountryProvider : CountryProvider
    {
        public DatabaseCountryProvider()
            : base(DataSources.Source.Database)
        {
        }

        public override List<IsinCountry> GetIsinCountries()
        {
            throw new NotImplementedException();
        }
    }
}
