using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_FactoryInjection
{
    class FileManager
    {
        IDataAccessObject dataAccessObject;

        public FileManager()
        {
            dataAccessObject = FactoryClass.CreateDataAccessObject();
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
