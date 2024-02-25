using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWarehouse.Rpositories;

namespace MyWarehouse.Strategies
{
    public class SellProductStrategy:IWarehouseStrategy
    {
        private readonly IProductRepository productRepository;
        public SellProductStrategy(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public char Id => 'd';

        public string Name => "Sell a product";

        public void Process()
        {
            Console.WriteLine("Product name:");
            var name=Console.ReadLine();
            Console.WriteLine("Count:");
            var count =int.Parse(Console.ReadLine());
            
            var allProducts= productRepository.GetAllProducts();
            var product = allProducts.FirstOrDefault(prod => prod.Name == name);
            if (product==null) 
            {
                Console.WriteLine("That product was not found!");
            }
            else if (product.Count < count)
            {
                Console.WriteLine("You don't have enough of this product!");
            }
            else
            {
                product.Count-=count;
                productRepository.UpdateProduct(name, product);
                Console.WriteLine("Successfully sold");
            }

        }
    }       
}
