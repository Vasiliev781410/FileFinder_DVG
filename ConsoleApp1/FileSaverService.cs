using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ModuleTwo
{
    public interface IFileSaverService
    {
        bool SaveFile(string content, string location, string fileName);
    }

    public class FileSaverService : IFileSaverService
    {
        public bool SaveFile(string content, string location, string fileName)
        {
            var result = false;
            
            string fileNameNew = ReNameFile(fileName);

            using (StreamWriter writer = new StreamWriter(location + fileNameNew, true))
            {
                writer.Write(content);
                writer.Close();

                result = true;
            }


            return result;
        }

        public string ReNameFile(string fileName)
        {

            var chars = fileName.ToCharArray();
            var str = "";
            for (int ctr = 0; ctr < chars.Length - 4; ctr++)
            {
                str = str + chars[ctr];
            }
            str = str + "_reverse.txt";

            return str;
        }
    }

}

