using System;
using ISIN_Validator.Models;

namespace ISIN_Validator
{
    public class IsinCreator
    {
        private const int ValidIsinLength = 12;

        public Isin CreateIsin(string input)
        {
            if (CheckIfInputIsValid(input))
            {
                return new Isin(input);
            }
            throw new Exception("Input has incorrect length");
        }

        private static bool CheckIfInputIsValid(string input)
        {
            return input != null && input.Length == ValidIsinLength;
        }
    }
}
