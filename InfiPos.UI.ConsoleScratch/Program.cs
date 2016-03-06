using InfiPos.Core;
using InfiPos.Infras.Data.EFRepos;
using InfiPos.Infras.Data.InMemory;
using System;
using System.Data.Entity;

namespace InfiPos.UI.ConsoleScratch
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var productRepo = new ProductEFRepo())
            {
                //var ajam = Sample.Ajam;
                //ajam.Id = 2;
                //ajam.Name = "Ajam Goreng";
                //productRepo.Save(ajam);
                //Console.WriteLine(ajam.Name);

                var products = productRepo.GetAll(1, 3);
                foreach (var p in products)
                {
                    Console.WriteLine(p.Name);
                }
            }
            //productRepo.Save(Sample.Ajam);
            //Console.WriteLine(productRepo.GetById(2).Name);
        }

        static void MainMain(string[] args)
        {
            var momogi = new Product { Code = "P01", Name = "Momogi", UnitPrice = 500m };
            var pepsi = new Product { Code = "P02", Name = "Pepsi", UnitPrice = 5000m };
            var ajam = new Product { Code = "P03", Name = "Ajam", UnitPrice = 50000m };

            var suyama = new Employee { Code = "E01", Name = "Michael Suyama", Birthdate = DateTime.Now.AddYears(-50), };
            var nancy = new Employee { Code = "E02", Name = "Nancy Davolio", Birthdate = DateTime.Now.AddYears(-40), };

            var sale = new Sale { Code = "S01", Sales = suyama };
            //sale.Products.Add(momogi);
            //sale.Products.Add(momogi);
            //sale.Products.Add(pepsi);

            //var sli = new SaleLineItem { Product = momogi, Quantity = 2 };
            //var sli2 = new SaleLineItem { Product = pepsi, Quantity = 1 };
            //sale.LineItems.Add(sli);
            //sale.LineItems.Add(sli2);

            sale.AddLineItem(momogi, 2);
            sale.AddLineItem(pepsi);

            Console.WriteLine(sale.GetTotal());
        }

        //static void ShowReceipt(Sale sale)
        //{
        //    Console.WriteLine("{0} {1}\n{2} {3}", sale.Code, sale.Time, sale.Sales.Code, sale.Sales.Name);
        //    foreach (var p in sale.Products)
        //        Console.WriteLine("{0} {1} {2}", p.Code, p.Name, p.UnitPrice);
        //    Console.WriteLine(sale.GetTotal());
        //}
    }
}
