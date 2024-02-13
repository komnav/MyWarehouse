using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWarehouse.Rpositories;

namespace MyWarehouse.Strategies
{
    public class RemoveProductStrategy : IWarehouseStrategy
    {
        private readonly IProductRepository productRepository;
        public RemoveProductStrategy(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public char Id => 'c';

        public string Name => "Remove product";

        public void Process()
        {
            Console.WriteLine("Product name:");
            string names = Console.ReadLine();
            productRepository.RemoveProduct(names);
            Console.WriteLine("Product deleted");
        }
    }
}
