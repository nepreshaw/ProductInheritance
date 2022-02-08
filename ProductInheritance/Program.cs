using System;
using System.Collections.Generic;

namespace ProductInheritance {
    class Program {
        static void Main(string[] args) {

            List<Product> salesOrder = new List<Product>();

            Product widget1 = new Widget("w1", 50, "Small", "red");
            Product widget2 = new Widget("w2", 100, "medium", "white");
            Product widget3 = new Widget("w3", 200, "large", "blue");
            Product service = new Service("svc", 500, "premium", 5);

            //dont have to create the variable then add the variable to the collection
            salesOrder.Add(widget1);
            salesOrder.Add(widget2);
            salesOrder.Add(widget3);
            salesOrder.Add(service);

            decimal salesOrderTotal = 0;

            foreach (Product p in salesOrder) {
                salesOrderTotal += p.Price;
                if (p is Widget) {
                    Widget w = p as Widget;
                    Console.WriteLine($"{w.Code} | {w.Price:c} | {w.Size} | {w.Color}");
                    continue;
                }
                if (p is Service) {
                    Service s = p as Service;
                    Console.WriteLine($"{s.Code} | {s.Price:c} | {s.ServiceLevel} | {s.NumberOfYears}");
                    continue;
                }
            }
            Console.WriteLine($"total sales order is {salesOrderTotal:c}");
            //Widget w = new Widget();
            //Console.WriteLine(w.ToPrint());

            ////new Product is a call to a constructor
            //Product p = new Product("Echo", 123.45m);
            //string message = p.ToPrint();
            //Console.WriteLine(message);

            //Service s1 = new Service("Basic", 100, "Basic", 3);
            //Console.WriteLine(s1.ToPrint());
        }
    }
}
