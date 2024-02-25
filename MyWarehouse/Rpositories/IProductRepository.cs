namespace MyWarehouse.Rpositories
{
    public interface IProductRepository
    {
        void AddProduct(string name, int count);

        Product[] GetAllProducts();

        void RemoveProduct(string name);

        void UpdateProduct(string name, Product product);
    }
}
