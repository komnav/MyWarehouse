
using Microsoft.Extensions.DependencyInjection;
using MyWarehouse;
using MyWarehouse.Rpositories;
using MyWarehouse.Strategies;

var services = new ServiceCollection();

services.AddSingleton<IWarehouseStrategyResolver, WarehouseStrategyResolver>();

services.AddSingleton<IProductRepository, ProductFileRepository>();

services.AddSingleton<IWarehouseStrategy, ShowProductsStrategy>();
services.AddSingleton<IWarehouseStrategy, AddProductStrategy>();
services.AddSingleton<IWarehouseStrategy, RemoveProductStrategy>();
services.AddSingleton<IWarehouseStrategy, NoOperationStrategy>();
services.AddSingleton<IWarehouseStrategy, ShowWarehousesStrategy>();

services.AddSingleton<ApplicationStartup>();
var provider = services.BuildServiceProvider();

ApplicationStartup applicationStartup = provider.GetRequiredService<ApplicationStartup>();
applicationStartup.Start();