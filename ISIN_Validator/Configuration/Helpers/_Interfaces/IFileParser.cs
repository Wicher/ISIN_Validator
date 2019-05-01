using ISIN_Validator.Configuration.Models;

namespace ISIN_Validator.Configuration.Helpers._Interfaces
{
    public interface IFileParser
    {
        Config ParseConfiguration(string input);
    }
}
