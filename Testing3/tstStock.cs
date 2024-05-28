using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {

        string Producttype = "sneaker";
        string Size = "8";
        string StockQuantity = "5";
        
        string Daterestocked = DateTime.Now.ToShortDateString();
        



        public bool OK { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            clsStock AnStock = new clsStock();

            Assert.IsNotNull(AnStock);
        }

        ////////////////////////////////////////////////////////////////////PROPERTY TESTS!!!!!////////////////////////////////////////////////////////////////////////////////////////
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

            Int32 StockId = 1;

            Found = AnStock.Find(StockId);

            Assert.IsTrue(Found);

        }

        ////////////////////////////////////////////////////////////////////FOUND TESTS!!!!!////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]

        public void TestStockIdFound()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockId = 1;

            Found = AnStock.Find(StockId);

            if (AnStock.StockId != 1)
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

            Int32 StockId = 1;

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

            Int32 StockId = 1;

            Found = AnStock.Find(StockId);

            if (AnStock.Size != "8")
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

            Int32 StockId = 1;

            Found = AnStock.Find(StockId);

            if (AnStock.StockQuantity != 5)
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

            Int32 StockId = 1;

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

            Int32 StockId = 1;

            Found = AnStock.Find(StockId);

            if (AnStock.Daterestocked != Convert.ToDateTime("28/05/2024"))
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

            Int32 StockId = 1;

            Found = AnStock.Find(StockId);

            if (AnStock.Discontinued != false)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        ////////////////////////////////////////////////////////////////////VALID TESTS!!!!!/////////////////////////////////////////////////////////
        
        
        
        
        
        [TestMethod]

        public void ValidMethodOK()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

           
            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);
            Assert.AreEqual(Error, "");
        }


        // VALID Producttype tests

        [TestMethod]

        public void ProducttypeMinLessOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string Producttype = "";

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void ProducttypeMin()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string Producttype = "a";

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ProducttypeMinPlusOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string Producttype = "aa";

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ProducttypeMaxLessOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string Producttype = "aaaaaaaaaaaaaaaaaaa";

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ProducttypeMax()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string Producttype = "aaaaaaaaaaaaaaaaaaaa";

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ProducttypeMid()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string Producttype = "aaaaaaaaaa";

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreEqual(Error, "");
        }


        [TestMethod]

        public void ProducttypeMaxPlusOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string Producttype = "aaaaaaaaaaaaaaaaaaaaa";

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void ProducttypeExtremeMax()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string Producttype = "";
            Producttype = Producttype.PadRight(100, 'a');

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreNotEqual(Error, "");
        }

        // VALID Daterestocked tests


        [TestMethod]

        public void DaterestockedExtremeMin()
        {

            clsStock AnStock = new clsStock();

            String Error = "";

            DateTime TestDate;
            
            TestDate = DateTime.Now.Date.AddYears(-100);

            string Daterestocked = TestDate.ToString();

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void DaterestockedMinLessOne()
        {

            clsStock AnStock = new clsStock();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date.AddDays(-1);

            string Daterestocked = TestDate.ToString();

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void DaterestockedMin()
        {

            clsStock AnStock = new clsStock();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            string Daterestocked = TestDate.ToString();

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void DaterestockedMinPlusOne()
        {

            clsStock AnStock = new clsStock();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date.AddDays(1);

            string Daterestocked = TestDate.ToString();

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void DaterestockedExtremeMax()
        {

            clsStock AnStock = new clsStock();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date.AddYears(100);

            string Daterestocked = TestDate.ToString();

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void DaterestockedInvalidData()
        {

            clsStock AnStock = new clsStock();

            String Error = "";

            string Daterestocked = "this is not a date";

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreNotEqual(Error, "");

        }




        // VALID Size tests

        [TestMethod]
        public void SizeMinLessOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string Size = "";

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SizeMin()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string Size = "a";

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMinPlusOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string Size = "aa";

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMaxLessOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string Size = "aaaaaaaaa";

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMax()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string Size = "aaaaaaaaaa";

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMaxPlusOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string Size = "";

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SizeMid()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string Size = "aaaaa";

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeExtremeMax()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string Size = "";

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreNotEqual(Error, "");
        }

        // VALID StockQuantity tests

        [TestMethod]
        public void StockQuantityMinLessOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockQuantity = "";

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMin()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockQuantity = "a";

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMinPlusOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockQuantity = "aa";

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMaxLessOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockQuantity = "";
            StockQuantity = StockQuantity.PadRight(49, 'a');

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMax()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockQuantity = "";
            StockQuantity = StockQuantity.PadRight(50, 'a');

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMaxPlusOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockQuantity = "";
            StockQuantity = StockQuantity.PadRight(51, 'a');

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMid()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockQuantity = "";
            StockQuantity = StockQuantity.PadRight(50, 'a');

            Error = AnStock.Valid(Producttype, Size, Daterestocked, StockQuantity);

            Assert.AreEqual(Error, "");
        }

    }

}
