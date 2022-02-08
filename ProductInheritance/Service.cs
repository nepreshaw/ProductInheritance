using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInheritance {
    public class Service : Product {

        public string ServiceLevel { get; set; } = "Basic";
        public int NumberOfYears { get; set; } = 1;

        public override string ToPrint() {
            return $"{base.ToPrint()} | {ServiceLevel} | {NumberOfYears}";
        }

        public Service(string Code, decimal Price, string ServiceLevel, int NumberOfYears) 
            : base (Code, Price){
            this.ServiceLevel = ServiceLevel;
            this.NumberOfYears = NumberOfYears;
        }

        public Service() {

        }

    }
}
