using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public string ProductCode { get; set; }
    public string ProductName { get; set; }
    public string ProductCategory { get; set; }
    public int Quantity { get; set; }
    public decimal ProductPrice { get; set; }
    public string Warehouse { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var productsList = new List<Product>
        {
            new Product { ProductCode = "1", ProductName = "Сыр", ProductCategory = "Молочные продукты", Quantity = 5, ProductPrice = 10.67m, Warehouse = "Склад1" },
            new Product { ProductCode = "2", ProductName = "Хлеб", ProductCategory = "Хлебобулочные изделия", Quantity = 43, ProductPrice = 11.54m, Warehouse = "Склад2" },
            new Product { ProductCode = "3", ProductName = "Колбаса", ProductCategory = "Колбасные изделия", Quantity = 34, ProductPrice = 12.43m, Warehouse = "Склад1" },
            new Product { ProductCode = "1", ProductName = "Сыр", ProductCategory = "Молочные продукты", Quantity = 5, ProductPrice = 13.24m, Warehouse = "Склад2" },
        };

        Console.WriteLine("Запрос 1");
        var totalValuePerWarehouse = productsList.GroupBy(p => p.Warehouse)
            .Select(g => new { Warehouse = g.Key, TotalValue = g.Sum(p => p.ProductPrice * p.Quantity) });

        foreach (var warehouse in totalValuePerWarehouse)
        {
            Console.WriteLine($"Склад: {warehouse.Warehouse}, Стоимость товаров: {warehouse.TotalValue}");
        }

        Console.WriteLine("\nЗапрос 2");
        var maxPricePerCategory = productsList.GroupBy(p => p.ProductCategory)
            .Select(g => new { Category = g.Key, MaxPrice = g.Max(p => p.ProductPrice) });

        foreach (var category in maxPricePerCategory)
        {
            Console.WriteLine($"Категория: {category.Category}, Макс. цена: {category.MaxPrice}");
        }

        Console.WriteLine("\nЗапрос 3");
        var avgPricePerWarehouse = productsList.GroupBy(p => p.Warehouse)
            .Select(g => new { Warehouse = g.Key, AvgPrice = g.Average(p => p.ProductPrice) });

        foreach (var warehouse in avgPricePerWarehouse)
        {
            Console.WriteLine($"Склад: {warehouse.Warehouse}, Средняя цена: {warehouse.AvgPrice}");
        }

        var overallAvgPrice = productsList.Average(p => p.ProductPrice);
        Console.WriteLine($"Средняя цена по всем складам: {overallAvgPrice}");

        Console.WriteLine("\nЗапрос 4");
        var cheapestProduct = productsList.OrderBy(p => p.ProductPrice).FirstOrDefault();
        Console.WriteLine($"Самый дешёвый товар: {cheapestProduct?.ProductName}, Цена: {cheapestProduct?.ProductPrice}");

        Console.WriteLine("\nЗапрос 5");
        var warehouseWithMinValue = productsList.GroupBy(p => p.Warehouse)
            .Select(g => new { Warehouse = g.Key, TotalValue = g.Sum(p => p.ProductPrice * p.Quantity) })
            .OrderBy(g => g.TotalValue).FirstOrDefault();

        Console.WriteLine($"Склад с наименьшей стоимостью товаров: {warehouseWithMinValue?.Warehouse}, Стоимость: {warehouseWithMinValue?.TotalValue}");

        var productsInWarehouseWithMinValue = productsList.Where(p => p.Warehouse == warehouseWithMinValue?.Warehouse);

        foreach (var product in productsInWarehouseWithMinValue)
        {
            Console.WriteLine($"Артикул: {product.ProductCode}, Название: {product.ProductName}, Категория: {product.ProductCategory}, Количество: {product.Quantity}, Цена: {product.ProductPrice}, Склад: {product.Warehouse}");
        }
    }
}