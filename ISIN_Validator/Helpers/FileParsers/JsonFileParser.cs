using ISIN_Validator.Helpers.FileParsers._Interfaces;
using Newtonsoft.Json;

namespace ISIN_Validator.Helpers.FileParsers
{
    public class JsonFileParser<T> : IFileParser<T>
        where T: class
    {
        public T Parse(string input)
        {      
            var parsedObject = JsonConvert.DeserializeObject<T>(input);
            return parsedObject;
        }
    }
}
