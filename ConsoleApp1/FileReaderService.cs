using System;
using System.IO;

namespace ModuleTwo
{
    public interface IFileReaderService
    {
        string GetFileContent(string location, string fileName);
    }

    public class FileReaderService : IFileReaderService
    {
        public string GetFileContent(string location, string fileName)
        {
            try
            {
                using (StreamReader sr = new StreamReader(location + "/" + fileName)) //TODO improve
                {
                    string line = sr.ReadToEnd();
                    Console.WriteLine(line);
                    char[] arr = line.ToCharArray();
                    Array.Reverse(arr);
                    return new string(arr);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                throw e;
            }
        }
    }
}
