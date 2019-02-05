using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace _006_Ninject
{
    class ConfigFileObjectData : NinjectModule
    {
        public override void Load()
        {
            //this.Bind<IDataAccessObject>().To<FileDataObject>();
            this.Bind<IDataAccessObject>().To<StubFileDataObject>();
            this.Bind<FileManager>().ToSelf();
        }
    }
}
