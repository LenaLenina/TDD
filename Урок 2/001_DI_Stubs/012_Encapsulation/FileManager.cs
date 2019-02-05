using System.Collections.Generic;

namespace _012_EncapsulationProblem
{
    class FileManager
    {
        IDataAccessObject dataAccessObject;

#if DEBUG

        public FileManager(IDataAccessObject dataAccessObject)
        {
            this.dataAccessObject = dataAccessObject;
        }     
#else
        public FileManager()
        {
            this.dataAccessObject = new FileDataObject();
        }
#endif

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
