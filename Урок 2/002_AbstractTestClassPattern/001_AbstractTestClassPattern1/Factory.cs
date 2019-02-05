//#define DEBUG


namespace _001_AbstractTestClassPattern
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
