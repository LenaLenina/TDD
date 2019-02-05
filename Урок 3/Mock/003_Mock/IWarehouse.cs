using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Mock
{
    public interface IWarehouse
    {
        bool HasInventory(string productName);
        void Remove(string productName);
    }
}
