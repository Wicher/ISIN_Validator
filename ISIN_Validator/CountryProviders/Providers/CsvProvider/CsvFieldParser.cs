using System.Collections.Generic;
using ISIN_Validator.CountryProviders.Providers.CsvProvider._Interfaces;
using ISIN_Validator.Models;

namespace ISIN_Validator.CountryProviders.Providers.CsvProvider
{
    public class CsvFieldParser : ICsvFieldParser
    {
        private const int CountryCodeIndex = 0;
        private const int CountryNameIndex = 1;

        private List<IsinCountry> ParsedFields { get; } = new List<IsinCountry>();

        public List<IsinCountry> ParseFields(List<string[]> fieldsList)
        {
            foreach (var item in fieldsList)
            {
                string countryCode = item[CountryCodeIndex];
                string countryName = item[CountryNameIndex];
                var isinCountry = new IsinCountry(countryCode, countryName);
                ParsedFields.Add(isinCountry);
            }
            return ParsedFields;
        }
    }
}
