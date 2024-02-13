namespace MyWarehouse.Strategies
{
    public class ShowWarehousesStrategy : IWarehouseStrategy
    {
        public char Id => 'd';

        public string Name => "Show warehouses";

        public void Process()
        {
            Console.WriteLine("No warehouses");
        }
    }
}
