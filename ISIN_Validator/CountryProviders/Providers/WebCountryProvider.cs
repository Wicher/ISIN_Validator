using System;
using System.Collections.Generic;
using ISIN_Validator.CountryProviders._Enums;
using ISIN_Validator.Models;

namespace ISIN_Validator.CountryProviders.Providers
{
    public class WebCountryProvider : CountryProvider
    {
        public WebCountryProvider()
            : base(DataSources.Source.Web)
        {
        }

        public override List<IsinCountry> GetIsinCountries()
        {
            throw new NotImplementedException();
        }
    }
}
