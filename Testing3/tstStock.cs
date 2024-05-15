using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        public bool OK { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            clsStock AnStock = new clsStock();

            Assert.IsNotNull(AnStock);
        }

        //PROPERTY TESTS!!!!!//

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

        [TestMethod]

        public void FindMethodOK()
        { clsStock AnStock = new clsStock();

            Boolean Found = false;

            Int32 StockId = 3;

            Found = AnStock.Find(StockId);

            Assert.IsTrue(Found);

        }

        //FOUND TESTS!!!!!//

        [TestMethod]

        public void TestStockIdFound()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockId = 3;

            Found = AnStock.Find(StockId);

            if (AnStock.StockId != 3)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestProducttypeFound()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockId = 3;

            Found = AnStock.Find(StockId);

            if (AnStock.Producttype != "sneaker")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void TestSizeFound()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockId = 3;

            Found = AnStock.Find(StockId);

            if (AnStock.Size != "5")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestStockQuantityFound()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockId = 3;

            Found = AnStock.Find(StockId);

            if (AnStock.StockQuantity != 4)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestRestockneededFound()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockId = 3;

            Found = AnStock.Find(StockId);

            if (AnStock.Restockneeded != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void TestDaterestockedFound()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockId = 3;

            Found = AnStock.Find(StockId);

            if (AnStock.Daterestocked != Convert.ToDateTime("15/05/2024"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }


        [TestMethod]

        public void TestDiscontinuedFound()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockId = 3;

            Found = AnStock.Find(StockId);

            if (AnStock.Discontinued != false)
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }







    }

}
