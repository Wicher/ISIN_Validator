using System.IO;
using ISIN_Validator.Helpers.FileReaders._Interfaces;

namespace ISIN_Validator.Helpers.FileReaders
{
    public class FileReader : IFileReader
    {
        public string ReadFile(string fileFullPath)
        {
            if(CheckIfFileExist(fileFullPath))
            {
                return File.ReadAllText(fileFullPath);
            }
            throw new FileNotFoundException($"File does not exist: {fileFullPath}");
        }

        private static bool CheckIfFileExist(string fileFullPath)
        {
            return File.Exists(fileFullPath);
        }
    }
}
