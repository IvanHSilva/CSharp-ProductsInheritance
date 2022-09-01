using System;
using System.Globalization;

namespace ProductsInheritance.Entities {
    public class UsedProduct : Product {
        // Attributes
        public DateTime ManufactureDate { get; set; }

        // Constructors
        public UsedProduct() {}

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price) {
            ManufactureDate = manufactureDate;
        }

        // Methods
        public override string PriceTag() {
            string tag = $"{Name} $ {Price.ToString("F2", CultureInfo.InvariantCulture)}";
            tag += $" (Data de fabricação: {ManufactureDate:dd/MM/yyyy})";
            return tag;
        }
    }
}
