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
        public override string ToString() {
            return base.ToString() + $"(Data de fabricação: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
