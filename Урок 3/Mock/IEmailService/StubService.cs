﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Mock
{
    public class StubService : IWebService
    {
        public Exception ToThrow;
        public void LogError(string message)
        {
            if (ToThrow != null)
            {
                throw ToThrow;
            }
        }
    }
}
