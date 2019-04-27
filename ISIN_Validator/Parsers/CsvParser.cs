using Microsoft.VisualBasic.FileIO;

namespace ISIN_Validator.Parsers
{
    public class CsvParser : TextFieldParser
    {
        public CsvParser(string filePath) 
            : base(filePath)
        {
            CommentTokens = new[] {"#"};
            SetDelimiters(",");
            HasFieldsEnclosedInQuotes = true;
        }
    }
}
