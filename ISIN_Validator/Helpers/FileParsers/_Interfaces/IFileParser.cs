namespace ISIN_Validator.Helpers.FileParsers._Interfaces
{
    public interface IFileParser<out T>
    {
        T Parse(string input);
    }
}
