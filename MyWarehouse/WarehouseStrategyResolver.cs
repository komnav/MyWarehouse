using MyWarehouse.Strategies;

namespace MyWarehouse
{
    public class WarehouseStrategyResolver : IWarehouseStrategyResolver
    {
        private readonly IEnumerable<IWarehouseStrategy> strategies;
        public WarehouseStrategyResolver(IEnumerable<IWarehouseStrategy> strategies)
        {
            this.strategies = strategies;
        }

        public IWarehouseStrategy Resolve(char id)
        {
            var strategy = strategies.FirstOrDefault(x => x.Id == id);
            if (strategy == null)
                strategy = strategies.Single(s => s.Id == IWarehouseStrategy.NoOperationId);
            return strategy;
        }
    }
}
