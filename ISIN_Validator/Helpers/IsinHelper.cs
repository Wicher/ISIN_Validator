using ISIN_Validator.Constants;

namespace ISIN_Validator.Helpers
{
    public class IsinHelper
    {
        public static string ExtractCountry(string input)
        {
            return input.Substring(IsinConstraints.CountryStartIndex, IsinConstraints.CountryLength);
        }

        public static string ExtractNumber(string input)
        {
            return input.Substring(IsinConstraints.NumberStartIndex, IsinConstraints.NumberLength);
        }

        public static string ExtractCheckDigit(string input)
        {
            return input.Substring(IsinConstraints.CheckDigitStartIndex, IsinConstraints.CheckDigitLength);
        }
    }
}
