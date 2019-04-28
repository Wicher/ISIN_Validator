using ISIN_Validator.Configuration.Models;

namespace ISIN_Validator.Configuration._Interfaces
{
    public interface IConfigurationReader
    {
        Config LoadConfig();
    }
}
