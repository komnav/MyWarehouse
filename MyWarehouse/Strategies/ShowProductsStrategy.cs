using MyWarehouse.Rpositories;

namespace MyWarehouse.Strategies
{
    public class ShowProductsStrategy : IWarehouseStrategy
    {
        private readonly IProductRepository productRepository;
        public ShowProductsStrategy(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public char Id => 'a';

        public string Name => "Show products";

        public void Process()
        {
            Product[] products = productRepository.GetAllProducts();
            Console.WriteLine("Show:");
            foreach (var prod in products)
            {
                Console.WriteLine($"{prod.Name} {prod.Count}");
            }
        }
    }
}
