using System.Collections.Generic;
using ISIN_Validator._Enums;

namespace ISIN_Validator_Tests.Configuration_Tests
{
    public class Configuration_TestConstants
    {
        public static Dictionary<DataSources.Source, string> DataSourcesList = new Dictionary<DataSources.Source, string>
        {
            { DataSources.Source.Csv, "CSV" },
            { DataSources.Source.Database, "DATABASE" },
            { DataSources.Source.Web, "WEB"}
        };

        public const string CorrectConfigFileContents =
            "{\r\n  " +
            "\"DataSources\": {\r\n    " +
            "\"Csv\": \"CSV\",\r\n    " +
            "\"Database\": \"DATABASE\",\r\n    " +
            "\"Web\": \"WEB\"\r\n  " +
            "}\r\n}";

        public const string IncorrectConfigFileContents =
            "{\r\n  " +
            "\"DataSources\": {\r\n    " +
            "\"Csv\": \"CSV\",\r\n    " +
            "\"Database\": \"DATABASE\",\r\n    " +
            "\"Web\": \"WEB\"\r\n  ";
    }
}
