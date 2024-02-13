using MyWarehouse.Rpositories;

namespace MyWarehouse.Strategies
{
    public class AddProductStrategy : IWarehouseStrategy
    {
        private readonly IProductRepository productRepository;
        public AddProductStrategy(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public char Id => 'b';

        public string Name => "Add a new product";

        public void Process()
        {
            Console.WriteLine("Product name:");
            string name = Console.ReadLine();
            Console.WriteLine("Count:");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Product added!");
            productRepository.AddProduct(name, count);
        }
    }
}
