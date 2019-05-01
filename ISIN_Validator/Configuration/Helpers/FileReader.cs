using System.IO;
using ISIN_Validator.Configuration.Helpers._Interfaces;

namespace ISIN_Validator.Configuration.Helpers
{
    public class FileReader : IFileReader
    {
        public string ReadFile(string fileFullPath)
        {
            CheckIfFileExist(fileFullPath);
            string fileContents = File.ReadAllText(fileFullPath);
            return fileContents;
        }

        private static void CheckIfFileExist(string fileFullPath)
        {
            if (!File.Exists(fileFullPath))
                throw new FileNotFoundException("Configuration file does not exist");
        }
    }
}
