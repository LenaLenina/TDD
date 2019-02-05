﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_AbsFactoryInjection.AbstractFactory
{
    class StubConcreteFactory : IDataAccessObjectFactory
    {
        public IDataAccessObject CreateDataAccessObject()
        {
            return new StubFileDataObject();
        }
    }
}
