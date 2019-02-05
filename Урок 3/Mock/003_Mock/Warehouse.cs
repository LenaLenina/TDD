using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Mock
{
    public class Warehouse : IWarehouse
    {
        private DataAccess db;

        public Warehouse()
        {
            db = new DataAccess();
        }

        public virtual bool HasInventory(string productName)
        {
            return db.HasInventory(productName);
        }

        public virtual void Remove(string productName)
        {
            db.Remove(productName);
        }
    }
}
