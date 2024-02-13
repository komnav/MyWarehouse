using MyWarehouse.Strategies;

namespace MyWarehouse
{
    public class ApplicationStartup
    {
        private readonly IWarehouseStrategyResolver warehouseStrategyResolver;
        private readonly IEnumerable<IWarehouseStrategy> warehouseStrategies;
        public ApplicationStartup(IWarehouseStrategyResolver warehouseStrategyResolver, IEnumerable<IWarehouseStrategy> strategies)
        {
            this.warehouseStrategyResolver = warehouseStrategyResolver;
            this.warehouseStrategies = strategies;
        }

        public void Start()
        {
            if (!File.Exists("products.txt"))
                File.Create("products.txt").Close();

            while (true)
            {
                var allStrategies = warehouseStrategies.Where(s => s.Id != IWarehouseStrategy.NoOperationId);
                Console.WriteLine("Welcome!");
                Console.WriteLine("Choose the operation:");

                foreach (var strategyInList in allStrategies)
                {
                    Console.WriteLine($"{strategyInList.Id}) {strategyInList.Name}");
                }

                char action = char.Parse(Console.ReadLine());

                var strategy = warehouseStrategyResolver.Resolve(action);
                strategy.Process();

                Console.WriteLine("----------------------------------");
            }
        }
    }
}
