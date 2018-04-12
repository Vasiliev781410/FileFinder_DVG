using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading.Tasks;

namespace ModuleTwo
{
    public class ModuleTwoInvoker : IModuleTwoInvoker
    {
        public ModuleTwoInvoker()
        {
            _finderService = new FinderService();
            _fileReaderService = new FileReaderService();
            _fileSaverService = new FileSaverService();
        }

        private IFinderService _finderService { get; }
        private IFileReaderService _fileReaderService { get; }
        private IFileSaverService _fileSaverService { get; }

        public string[] FindFile()
        {
            var result = new string[2];

            try
            {
                Console.Write("Enter file name (only .txt file extension): ");
                string find = Console.ReadLine();

                Console.ReadKey();
                result = _finderService.FindFile(@"D:\DVG\",find);
            }
            catch (Exception e)
            {            
                Console.WriteLine(e.Message);
                //throw e;
            }

            return result;
        }

        public string GetFileContent(string location, string fileName)
        {
            var result = string.Empty;

            try
            {
                result = _fileReaderService.GetFileContent(location, fileName);
            }
            catch (Exception e)
            {
                // your code here
            }

            return result;
        }

        public bool SaveFile(string content, string location, string fileName)
        {
            var result = false;

            try
            {
                result = _fileSaverService.SaveFile(content, location, fileName);
            }
            catch (Exception e)
            {
                // your code here
            }

            return result;
        }
    }
}
