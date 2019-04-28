using System;
using System.Collections.Generic;
using ISIN_Validator.CountryProviders.Providers.CsvProvider._Interfaces;

namespace ISIN_Validator.CountryProviders.Providers.CsvProvider
{
    public class CsvFieldValidator : ICsvFieldValidator
    {
        private const int ValidSplittedLineFieldsCount = 2;

        private List<string[]> ValidatedFields { get; } = new List<string[]>();

        public List<string[]> ValidateFields(List<string[]> fieldsList)
        {
            foreach (var item in fieldsList)
            {
                if(ValidateFieldsCount(item))
                    ValidatedFields.Add(item);
                else
                {
                    Console.WriteLine($"Skipping - Incorrect format of following line: {string.Join(" ", item)}");
                }
            }
            return ValidatedFields;
        }

        private static bool ValidateFieldsCount(IReadOnlyCollection<string> splittedLine)
        {
            return splittedLine.Count == ValidSplittedLineFieldsCount;
        }
    }
}
