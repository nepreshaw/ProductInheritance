using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInheritance {
    public class Widget : Product {
        public string Size { get; set; } = "Medium";
        public string Color { get; set; } = "Black";

        public override string ToPrint() {
            return $"{base.ToPrint()} | {Size} | {Color}";
        }
       
        //calls the parent constructor
        public Widget(string Code, decimal Price, string Size, string Color)
            : base(Code, Price){
            this.Size = Size;
            this.Color = Color;

        }
        //calls default constructor and parent constructor
        public Widget() : base(){

        }
    }
}
