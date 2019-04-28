namespace ISIN_Validator.Constants
{
    public static class IsinConstraints
    {
        public const int ValidIsinLength = 12;

        public const int CountryStartIndex = 0;
        public const int CountryLength = 2;

        public const int NumberStartIndex = 2;
        public const int NumberLength = 9;

        public const int CheckDigitStartIndex = 11;
        public const int CheckDigitLength = 1;
    }
}
