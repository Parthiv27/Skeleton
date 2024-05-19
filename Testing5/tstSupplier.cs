using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {

        //////////////////////////// Property OK Tests /////////////////////////////////
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Assert.IsNotNull(ASupplier);
        }

        [TestMethod]
        public void SupplierIDPropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Int32 TestData = 1;
            ASupplier.SupplierID = TestData;
            Assert.AreEqual(ASupplier.SupplierID, TestData);
        }

        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            String TestData = "Supplier Name";
            ASupplier.SupplierName = TestData;
            Assert.AreEqual(ASupplier.SupplierName, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            String TestData = "abc@gmail.com";
            ASupplier.Email = TestData;
            Assert.AreEqual(ASupplier.Email, TestData);
        }


        [TestMethod]
        public void PhonePropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            String TestData = "0123456789";
            ASupplier.Phone = TestData;
            Assert.AreEqual(ASupplier.Phone, TestData);
        }

        [TestMethod]
        public void DateRegPropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            ASupplier.DateReg = TestData;
            Assert.AreEqual(ASupplier.DateReg, TestData);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean TestData = true;
            ASupplier.Active = TestData;
            Assert.AreEqual(ASupplier.Active, TestData);
        }


        //////////////////////////// Find Method Tests /////////////////////////////////

        [TestMethod]
        public void FindMethodOK()
        {

            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Int32 SupplierID = 3;
            Found = ASupplier.Find(SupplierID);
            Assert.IsTrue(Found);

        }

        //////////////////////////// Property Data Tests /////////////////////////////////

        [TestMethod]
        public void TestSupplierIDFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SuppierID = 3;
            Found = ASupplier.Find(SuppierID);
            if (ASupplier.SupplierID != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierNameFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SuppierID = 3;
            Found = ASupplier.Find(SuppierID);
            if (ASupplier.SupplierName != "Supplier C")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestEmailFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SuppierID = 3;
            Found = ASupplier.Find(SuppierID);
            if (ASupplier.Email != "supplierC@example.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestPhoneFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SuppierID = 3;
            Found = ASupplier.Find(SuppierID);
            if (ASupplier.Phone != "555-123-4567")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDateRegFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SuppierID = 3;
            Found = ASupplier.Find(SuppierID);
            if (ASupplier.DateReg != DateTime.Now.Date)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestActiveFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SuppierID = 3;
            Found = ASupplier.Find(SuppierID);
            if (ASupplier.Active != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }

}
