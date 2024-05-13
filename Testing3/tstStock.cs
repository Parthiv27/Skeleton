using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock AnStock = new clsStock();

            Assert.IsNotNull(AnStock);
        }

        [TestMethod]
        public void StockIDPropertyOK()
        {
            clsStock AnStock = new clsStock();

            int TestData = 1;

            AnStock.StockId = TestData;

            Assert.AreEqual(AnStock.StockId, TestData);
        }


        [TestMethod]
        public void ProducttypePropertyOK()
        {
            clsStock AnStock = new clsStock();

            string TestData = "Producttype";

            AnStock.Producttype = TestData;

            Assert.AreEqual(AnStock.Producttype, TestData);
        }

        [TestMethod]
        public void SizePropertyOK()
        {
            clsStock AnStock = new clsStock();

            string TestData = "Size";

            AnStock.Size = TestData;

            Assert.AreEqual(AnStock.Size, TestData);

        }

        [TestMethod]
        public void StockQuantityPropertyOK()
        {
            clsStock AnStock = new clsStock();

            int TestData = 4;

            AnStock.StockQuantity = TestData;

            Assert.AreEqual(AnStock.StockQuantity, TestData);

        }


        [TestMethod]
        public void RestockneededPropertyOK()
        {
            clsStock AnStock = new clsStock();
            
            Boolean TestData = true;

            AnStock.Restockneeded = TestData;

            Assert.AreEqual(AnStock.Restockneeded, TestData);

        }

        [TestMethod]
        public void DaterestockedPropertyOK()
        {
            clsStock AnStock = new clsStock();

            DateTime TestData = DateTime.Now.Date;

            AnStock.Daterestocked = TestData;

            Assert.AreEqual(AnStock.Daterestocked, TestData);

        }


        [TestMethod]
        public void DiscontinuedPropertyOK()
        {
            clsStock AnStock = new clsStock();

            Boolean TestData = false;

            AnStock.Discontinued = TestData;

            Assert.AreEqual(AnStock.Discontinued, TestData);

        }

    }

}
