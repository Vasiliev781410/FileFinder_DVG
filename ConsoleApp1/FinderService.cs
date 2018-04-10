using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ModuleTwo
{
    public interface IFinderService
    {
        List<string> FindFile(string baseDirectory, string fileName);
    }

    public class FinderService : IFinderService
    {
        public void FinderFile()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            Console.Write("Enter file name: ");
            string find = Console.ReadLine();

            var files = FindFile(@"C:\", find);
            Console.ReadKey();
        }

        public List<string> FindFile(string baseDirectory, string fileName)
        {
            var files = new List<string>();

            if (!Directory.Exists(baseDirectory))
            {
                return files;
            }

            try
            {
                Console.WriteLine(baseDirectory);
                files.AddRange(Directory.GetFiles(baseDirectory).Where(x => Path.GetFileName(x).ToLower() == fileName.ToLower()));

                if (files.Any()) // find 1st file and stop
                {
                    return files;
                }

                var direcotires = Directory.GetDirectories(baseDirectory);

                foreach (var directory in direcotires) // test all directory
                {
                    files.AddRange(FindFile(directory, fileName));

                    if (files.Any())
                    {
                        return files;
                    }
                }
            }
            catch { }

            return files;
        }
    }
}
