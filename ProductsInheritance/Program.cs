using ProductsInheritance.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProductsInheritance {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Número de produtos: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();
            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Produto {i}");
                Console.Write("Novo / Usado / Importado (n/u/i)?: ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (resp == 'n' || resp == 'N') {
                    products.Add(new Product(name, price));
                } else if (resp == 'i' || resp == 'I') {
                    Console.Write("Taxa da alfândega: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, fee));
                } else if (resp == 'u' || resp == 'U') {
                    Console.Write("Data de fabricação: ");
                    DateTime manufactured = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufactured));
                }
            }
            Console.WriteLine();
            Console.WriteLine("ETIQUETAS DE PREÇOS:");
            foreach (Product p in products) {
                Console.WriteLine(p.PriceTag());
            }
            Console.WriteLine();
        }
    }
}
