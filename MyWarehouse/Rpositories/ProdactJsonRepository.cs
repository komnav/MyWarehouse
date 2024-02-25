using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace MyWarehouse.Rpositories
{
    public class ProdactJsonRepository : IProductRepository
    {

        const string fileName = "Product.json";
        
        public void AddProduct(string name, int count)
        {
            
            var allProducts = GetAllProducts().ToList();
            var product = new Product
            {
                Name = name,
                Count = count
            };
            allProducts.Add(product);
            writeProductsToJsonFile(allProducts);
        }

        public Product[] GetAllProducts()
        {
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<Product[]>(jsonString);
        }

        private void writeProductsToJsonFile(List<Product> products)
        {
            string jsonString = JsonSerializer.Serialize(products);
            File.WriteAllText(fileName, jsonString);
        }

        public void RemoveProduct(string name)
        {
            var products = GetAllProducts().ToList();
            Product productToRemove = products.First(p => p.Name == name);
            products.Remove(productToRemove);
            writeProductsToJsonFile(products);
        }

        public void UpdateProduct(string name, Product product)
        {
            var products = GetAllProducts().ToList();
            int index = products.FindIndex(p => p.Name == name);
            products[index] = product;
            writeProductsToJsonFile(products);
        }

    }
}
