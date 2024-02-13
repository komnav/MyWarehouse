using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWarehouse.Strategies
{
    partial class NoOperationStrategy : IWarehouseStrategy
    {
        public char Id => IWarehouseStrategy.NoOperationId;

        public string Name => "Operation not found";

        public void Process()
        {
            Console.WriteLine("Operation not found!");
        }
    }
}
