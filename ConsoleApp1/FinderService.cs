using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace ModuleTwo
{
    public interface IFinderService
    {
        string[] FindFile(string baseDirectory, string fileName);
    }


    public class FinderService : IFinderService
    {
       

        public string[] FindFile(string baseDirectory, string fileName)
        {
            

            var files = new List<string>();
            string[] filePatn = new string[2];

            if (!Directory.Exists(baseDirectory))
            {
                filePatn[0] = baseDirectory;
                filePatn[1] = fileName;
                return filePatn;
            }

            try
            {
                Console.WriteLine(baseDirectory);
                files.AddRange(Directory.GetFiles(baseDirectory).Where(x => Path.GetFileName(x).ToLower() == fileName.ToLower()));

                if (files.Any()) // find 1st file and stop
                {
                    filePatn[0] = baseDirectory;
                    filePatn[1] = fileName;

                    return filePatn;
                }

                var direcotires = Directory.GetDirectories(baseDirectory);

                foreach (var directory in direcotires) // test all directory
                {
                    if (directory != "D:\\$RECYCLE.BIN")
                    {
                        files.AddRange(FindFile(directory, fileName));



                        if (files.Any())
                        {
                            filePatn[0] = directory;
                            filePatn[1] = fileName;

                            return filePatn;
                        }
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }

            return filePatn;
        }
    }
}

