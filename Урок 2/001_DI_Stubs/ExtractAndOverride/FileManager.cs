using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_ExtractAndOverride
{
    class FileManager 
    {
        public FileManager()
        {
        }

        protected virtual List<string> FindLogFileExtension()
        {
            return new FileDataObject().GetFiles();
        }

        public bool FindLogFile(string fileName)
        {
            List<string> files = FindLogFileExtension();

            foreach (var file in files)
            {
                if (file.Contains(fileName))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
