namespace MyWarehouse.Strategies
{
    public interface IWarehouseStrategy
    {
        const char NoOperationId = ' ';

        char Id { get; }

        string Name { get; }

        void Process();
    }
}
