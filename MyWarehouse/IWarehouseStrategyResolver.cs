using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWarehouse.Strategies;

namespace MyWarehouse
{
    public interface IWarehouseStrategyResolver
    {
        IWarehouseStrategy Resolve(char id);
    }
}
