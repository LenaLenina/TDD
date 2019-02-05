//#define DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_FactoryInjection
{
    class FactoryClass
    {
        static IDataAccessObject dataAcessObject;

        internal static IDataAccessObject CreateDataAccessObject()
        {
            if (dataAcessObject != null)
            {
                return dataAcessObject;
            }

            return new FileDataObject();
        }

#if DEBUG 
        public static void SetDataAccessObject(IDataAccessObject customDataObject)
        {
            dataAcessObject = customDataObject;
        }
#endif
    }
}
