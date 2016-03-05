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
            var repo = new EmployeeEFRepo();
            var service = new EmployeeService(repo);
            Console.WriteLine(service.GenerateCode());

            //var ctx = new PosContext();
            //var product = ctx.Products.SingleAsync(p => p.Id == 1).Result;
            //Console.WriteLine(product.Name);
            //ctx.Products.Add(Sample.Momogi);
            //ctx.SaveChangesAsync();
            //var momogi = ctx.Products.SingleAsync(p => p.Id == 1).Result;

            ////var task = ctx.Products.SingleAsync(p => p.Id == 1);
            ////Console.WriteLine("halo");
            ////Console.WriteLine("hola");
            ////Console.WriteLine(task.Result.Name);

            //ctx.Employees.Add(Sample.Suyama);
            //ctx.SaveChanges();

            //var suyama = ctx.Employees.SingleAsync(e => e.Id == 1).Result;
            //Console.WriteLine(suyama.Name);


            //var sale = new Sale { Sales = suyama };
            //sale.AddLineItem(momogi, 2);
            //ctx.Sales.Add(sale);
            //ctx.SaveChanges();
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
