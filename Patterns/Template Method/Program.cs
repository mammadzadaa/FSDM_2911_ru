using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Transactions;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            TxtDataReader txtDataReader = new TxtDataReader();
            Console.WriteLine(txtDataReader.GetProductTotalPrice("products.txt"));
            CsvDataReader csvDataReader = new CsvDataReader();
            Console.WriteLine(csvDataReader.GetProductTotalPrice("products.csv"));
        }
    }

    class Product
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
    abstract class DataReader
    {
        public abstract IEnumerable<Product> ReadProdctsFromFile(string fileName);
        public virtual decimal GetProductTotalPrice(string fileName)
        {
            var products = ReadProdctsFromFile(fileName);
            return products.Sum(x => x.Price);
        }
    }

    class TxtDataReader : DataReader
    {
        public override IEnumerable<Product> ReadProdctsFromFile(string fileName)
        {
            List<Product> products = new List<Product>();
            var lines = File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                var items = line.Split(':');
                products.Add(new Product()
                {
                    Title = items[0],
                    Price = decimal.Parse(items[1])
                });
            }
            return products;
        }
    }

    class CsvDataReader : DataReader
    {
        public override IEnumerable<Product> ReadProdctsFromFile(string fileName)
        {
            List<Product> products = new List<Product>();
            var lines = File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                var items = line.Split(',');
                products.Add(new Product()
                {
                    Title = items[0],
                    Price = decimal.Parse(items[1])
                });
            }
            return products;
        }
    }
}
