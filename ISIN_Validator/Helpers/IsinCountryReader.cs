﻿using System;
using System.Collections.Generic;
using System.IO;
using ISIN_Validator.Models;
using ISIN_Validator.Parsers;

namespace ISIN_Validator.Helpers
{
    public class IsinCountryReader
    {
        private const int CountryCodeIndex = 0;
        private const int CountryNameIndex = 1;
        private const int ValidSplittedLineLength = 2;

        private const string CountryPath = "DataFiles/Countries.csv";
        private static readonly string FilePath = Path.Combine(Environment.CurrentDirectory, CountryPath);

        public List<IsinCountry> GetIsinCountries()
        {
            var isinCountryList = new List<IsinCountry>();
            CheckIfCountryFileExist();
            using (var csvParser = new CsvParser(FilePath))
            {
                while (!csvParser.EndOfData)
                {
                    var fields = csvParser.ReadFields();
                    var validatedFields = ValidateFields(fields);
                    if(validatedFields == null) continue;
                    string countryCode = validatedFields[CountryCodeIndex];
                    string countryName = validatedFields[CountryNameIndex];
                    var isinCountry = new IsinCountry(countryCode, countryName);
                    isinCountryList.Add(isinCountry);
                }
            }
            return isinCountryList;
        }

        private static void CheckIfCountryFileExist()
        {
            if (!File.Exists(FilePath))
                throw new FileNotFoundException($"Country File does not exist under following path: {FilePath}");
        }

        private static string[] ValidateFields(string[] fields)
        {
            if (ValidateFieldsCount(fields)) return fields;
            Console.WriteLine($"Skipping - Incorrect format of following line: {string.Join(" ", fields)}");
            return null;
        }

        private static bool ValidateFieldsCount(IReadOnlyCollection<string> splittedLine)
        {
            return splittedLine.Count == ValidSplittedLineLength;
        }
    }
}
