using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("011_FileManagerTest")]

namespace _011_Encapsulation
{
    public class FileManager
    {
        IDataAccessObject dataAccessObject;

        public FileManager()
        {
            this.dataAccessObject = new FileDataObject();
        }

        internal FileManager(IDataAccessObject dataAccessObject)
        {
            this.dataAccessObject = dataAccessObject;
        }

        public bool FindLogFile(string fileName)
        {
            List<string> files = dataAccessObject.GetFiles();

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
