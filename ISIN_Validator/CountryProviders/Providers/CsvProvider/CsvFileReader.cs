using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using ISIN_Validator.Configuration._Interfaces;
using ISIN_Validator.CountryProviders.Providers.CsvProvider.Helpers;
using ISIN_Validator.CountryProviders.Providers.CsvProvider._Interfaces;
using ISIN_Validator.CountryProviders._Enums;
using System.Configuration;

namespace ISIN_Validator.CountryProviders.Providers.CsvProvider
{
    public class CsvFileReader : ICsvFileReader
    {
        private string CsvPath { get; }
        private string FilePath { get; }

        public CsvFileReader(IConfigurationProvider configurationProvider)
        {
            var section = ConfigurationManager.GetSection("dataSources") as NameValueCollection;

            //CsvPath = configurationProvider.Config.DataSourcesList[DataSources.Source.Csv];
            CsvPath = section["Csv"];
            FilePath = Path.Combine(Environment.CurrentDirectory, CsvPath);
        }

        public List<string[]> ReadFields()
        {
            CheckIfFileExist();
            var fieldsList = new List<string[]>();
            using (var csvFieldParser = new CsvFieldReader(FilePath))
            {
                //Skip Csv Header Line
                csvFieldParser.ReadLine();
                while (!csvFieldParser.EndOfData)
                {
                    fieldsList.Add(csvFieldParser.ReadFields());
                }
            }
            return fieldsList;
        }

        private void CheckIfFileExist()
        {
            if (!File.Exists(FilePath))
                throw new FileNotFoundException($"Country Csv File does not exist under following path: {FilePath}");
        }
    }
}
