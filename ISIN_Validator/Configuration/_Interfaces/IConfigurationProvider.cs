using ISIN_Validator.Configuration.Models;

namespace ISIN_Validator.Configuration._Interfaces
{
    public interface IConfigurationProvider
    {
        Config Config { get; }
    }
}
