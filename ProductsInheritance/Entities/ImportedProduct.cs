using System.Diagnostics;
using System.Globalization;
using System.Xml.Linq;

namespace ProductsInheritance.Entities {
    public class ImportedProduct : Product {
        // Attributes
        public double CustomsFee { get; set; }

        // Constructors
        public ImportedProduct() {}

        public ImportedProduct(string name, double price, double customsFee) 
            : base(name, price) {
            CustomsFee = customsFee;
        }

        // Methods
        public override string PriceTag() {
            string tag = $"{Name} $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)}";
            tag += $"(Taxa da alfândega: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
            return tag;
        }

        public double TotalPrice() {
            return Price + CustomsFee;
        }
    }
}
