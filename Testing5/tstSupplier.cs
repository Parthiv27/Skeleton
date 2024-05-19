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
            ASupplier.SupplierID= TestData;
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
    }
}
