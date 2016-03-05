using InfiPos.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InfiPos.Tests.Cores
{
    [TestClass]
    public class SaleTest
    {
        [TestMethod]
        public void add_2_momogi_and_1_pepsi_get_total_should_be_6000()
        {
            var sale = new Sale { Code = "S01", Sales = Sample.Suyama };
            sale.AddLineItem(Sample.Momogi, 2);
            sale.AddLineItem(Sample.Pepsi);

            Assert.AreEqual(6000m, sale.GetTotal());
        }

        [TestMethod]
        public void add_1_ajam_and_1_pepsi_get_total_should_be_6000()
        {
            var sale = new Sale { Code = "S01", Sales = Sample.Suyama };
            sale.AddLineItem(Sample.Ajam);
            sale.AddLineItem(Sample.Pepsi);

            Assert.AreEqual(55000m, sale.GetTotal());
        }

        [TestMethod]
        public void MyTestMethod()
        {
            var sale = new Sale { Code = "S01", Sales = Sample.Suyama };
            sale.AddLineItem(Sample.Ajam);
            sale.AddLineItem(Sample.Pepsi);
            Assert.AreEqual(55000m, sale.GetTotal());

            Sample.Pepsi.UnitPrice = 1000m;
            Assert.AreEqual(55000m, sale.GetTotal());
        }

        [TestMethod]
        public void DuplicateSli()
        {
            var sale = new Sale { Code = "S01", Sales = Sample.Suyama };
            sale.AddLineItem(Sample.Ajam);
            sale.AddLineItem(Sample.Pepsi);
            sale.AddLineItem(Sample.Ajam);

            Assert.AreEqual(sale.LineItems.Count, 2);
            var sli = sale.GetLineItem(Sample.Ajam);
            Assert.AreEqual(2, sli.Quantity);
        }
    }
}
