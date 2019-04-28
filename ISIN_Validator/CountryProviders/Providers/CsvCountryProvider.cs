using System.Collections.Generic;
using ISIN_Validator.CountryProviders._Enums;
using ISIN_Validator.Models;
using ISIN_Validator.CountryProviders.Providers.CsvProvider._Interfaces;

namespace ISIN_Validator.CountryProviders.Providers
{
    public class CsvCountryProvider : CountryProvider
    {
        private ICsvFileReader CsvFileReader { get; }
        private ICsvFieldValidator CsvFieldValidator { get; }
        private ICsvFieldParser CsvFieldParser { get; }

        public CsvCountryProvider(ICsvFileReader csvFileReader, 
            ICsvFieldValidator csvFieldValidator,
            ICsvFieldParser csvFieldParser)
            : base(DataSources.Source.Csv)
        {
            CsvFileReader = csvFileReader;
            CsvFieldValidator = csvFieldValidator;
            CsvFieldParser = csvFieldParser;
        }

        public override List<IsinCountry> GetIsinCountries()
        {
            var fieldsList = CsvFileReader.ReadFields();
            var validatedFields = CsvFieldValidator.ValidateFields(fieldsList);
            var parsedFields = CsvFieldParser.ParseFields(validatedFields);
            return parsedFields;
        }
    }
}
