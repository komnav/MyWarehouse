namespace MyWarehouse
{
    public class Product
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public object Id { get; internal set; }
    }
}
