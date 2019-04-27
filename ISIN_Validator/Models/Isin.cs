using ISIN_Validator.Helpers;

namespace ISIN_Validator.Models
{
    public class Isin
    {
        public string Country { get; }
        public string Number { get; }
        public string CheckDigit { get; }

        public bool Valid { get; private set; }

        public Isin(string input)
        {
            Country = IsinHelper.ExtractCountry(input);
            Number = IsinHelper.ExtractNumber(input);
            CheckDigit = IsinHelper.ExtractCheckDigit(input);
        }

        public override string ToString()
        {
            return Country + Number + CheckDigit;
        }
    }
}
