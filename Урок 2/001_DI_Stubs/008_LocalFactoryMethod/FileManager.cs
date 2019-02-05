using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_LocalAbstractMethod
{
    class FileManager 
    {
        public FileManager()
        {
        }

        protected virtual IDataAccessObject LocalFactoryMethod()
        {
            return new FileDataObject();
        }

        public bool FindLogFile(string fileName)
        {
            var dataAccessObject = LocalFactoryMethod();

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
