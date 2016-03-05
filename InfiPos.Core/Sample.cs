using System;

namespace InfiPos.Core
{
    public class Sample
    {
        public static Product Momogi = new Product { Id = 1, Code = "P01", Name = "Momogi", UnitPrice = 500m };
        public static Product Pepsi = new Product { Id = 2, Code = "P02", Name = "Pepsi", UnitPrice = 5000m };
        public static Product Ajam = new Product { Id = 3, Code = "P03", Name = "Ajam", UnitPrice = 50000m };

        public static Employee Suyama = new Employee { Id = 1, Code = "E01", Name = "Michael Suyama", Birthdate = DateTime.Now.AddYears(-50), };
        public static Employee Nancy = new Employee { Id = 2, Code = "E02", Name = "Nancy Davolio", Birthdate = DateTime.Now.AddYears(-40), };
    }
}
