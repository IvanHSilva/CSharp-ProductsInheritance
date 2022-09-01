using System.Globalization;
using System.Text;

namespace ProductsInheritance {
    public class Product {
        // Attributes
        public string Name { get; set; }
        public double Price { get; set; }

        // Constructors
        public Product() {}

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        // Methods
        public virtual string PriceTag() {
            string tag = $"{Name} $ {Price.ToString("F2", CultureInfo.InvariantCulture)}";
            return tag;
        }
    }
}
