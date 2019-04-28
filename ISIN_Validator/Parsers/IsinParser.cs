using System;
using ISIN_Validator.Constants;
using ISIN_Validator.Models;

namespace ISIN_Validator.Parsers
{
    public class IsinParser
    {
        public Isin ParseIsin(string input)
        {
            if (CheckIfInputIsValid(input))
            {
                return new Isin(input);
            }
            throw new Exception("Input has incorrect length");
        }

        private static bool CheckIfInputIsValid(string input)
        {
            return !string.IsNullOrEmpty(input) && input.Length == IsinConstraints.ValidIsinLength;
        }
    }
}
