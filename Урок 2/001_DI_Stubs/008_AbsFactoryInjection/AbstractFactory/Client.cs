using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_AbsFactoryInjection.AbstractFactory
{
    class Client
    {
        IDataAccessObjectFactory factory;

        public Client(IDataAccessObjectFactory factory)
        {
            this.factory = factory;
        }

        public IFileManager Run()
        {
            return new FileManager(factory.CreateDataAccessObject());
        }
    }
}
