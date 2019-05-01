using System.IO;
using ISIN_Validator.Configuration.Helpers._Interfaces;

namespace ISIN_Validator.Configuration.Helpers
{
    public class ConfigurationFileReader : IConfigurationFileReader
    {
        public string ReadConfigurationFile(string configurationFileFullPath)
        {
            CheckIfConfigurationFileExist(configurationFileFullPath);
            string fileContents = ReadFile(configurationFileFullPath);
            return fileContents;
        }

        private static void CheckIfConfigurationFileExist(string configurationFilePath)
        {
            if (!File.Exists(configurationFilePath))
                throw new FileNotFoundException("Configuration file does not exist");
        }

        private static string ReadFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}
