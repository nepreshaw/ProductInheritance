using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInheritance {
    public class Product {
        //bool defaults to false, strings default to null, decimal default to 0
        private bool Flag { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }

        public virtual string ToPrint() {
            return $"{GetType().ToString()} | {Code} | {Price:c}";
        }

        public Product(string Code, decimal Price) {
            Flag = true;
            this.Code = Code;
            this.Price = Price;

        }

        public Product() {

        }
    }
}
