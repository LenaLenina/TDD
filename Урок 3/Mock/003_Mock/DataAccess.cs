using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Mock
{
    class DataAccess
    {
        private List<string> db;

        public DataAccess()
        {
            db = new List<string>();
        }

        public bool HasInventory(string productName)
        {
            return db.Contains(productName);
        }

        public void Remove(string productName)
        {
            db.Remove(productName);
        }
    }
}
