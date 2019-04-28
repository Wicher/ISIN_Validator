using Microsoft.VisualBasic.FileIO;

namespace ISIN_Validator.CountryProviders.Providers.CsvProvider.Helpers
{
    public class CsvFieldReader : TextFieldParser
    {
        public CsvFieldReader(string filePath) 
            : base(filePath)
        {
            CommentTokens = new[] {"#"};
            SetDelimiters(",");
            HasFieldsEnclosedInQuotes = true;
        }
    }
}
