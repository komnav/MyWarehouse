namespace MyWarehouse.Rpositories
{
    public class ProductFileRepository : IProductRepository
    {
        public void AddProduct(string name, int count)
        {
            var allProducts = GetAllProducts();
            var newProducts = new string[allProducts.Length + 1];
            for (int i = 0; i < allProducts.Length; i++)
            {
                var product = allProducts[i];
                newProducts[i] = $"{product.Name} {product.Count}";
            }
            newProducts[allProducts.Length] = $"{name} {count}";
            File.WriteAllLines("products.txt", newProducts);
        }

        public Product[] GetAllProducts()
        {
            string[] productsFromFile = File.ReadAllLines("products.txt");
            Product[] products = new Product[productsFromFile.Length];
            for (int i = 0; i < productsFromFile.Length; i++)
            {
                var productFromFile = productsFromFile[i].Split(' ');
                products[i] = new Product()
                {
                    Name = productFromFile[0],
                    Count = int.Parse(productFromFile[1])
                };
            }
            return products;
        }

        public void RemoveProduct(string name)
        {
            var allProducts = GetAllProducts();
            var newProducts = new string[allProducts.Length - 1];
            for (int i = 0; i < allProducts.Length; i++)
            {
                var product = allProducts[i];
                if (product.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                    continue;

                newProducts[i] = $"{product.Name} {product.Count}";
            }
            File.WriteAllLines("products.txt", newProducts);
        }

        public void UpdateProduct(string name, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
