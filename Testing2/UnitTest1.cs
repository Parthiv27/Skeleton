using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOk()

        {
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        public void CustomerIdPropertyOK()
        {

            clsCustomer ACustomer = new clsCustomer();
            Int32 TestData = 1;
            ACustomer.CustomerId = TestData;
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }
        [TestMethod]
        public void FirstNamePropertyOK()
        {

            clsCustomer ACustomer = new clsCustomer();
            string TestData = "FirstName";
            ACustomer.FirstName = TestData;
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }
        [TestMethod]
        public void SurNamePropertyOK()
        {

            clsCustomer ACustomer = new clsCustomer();
            string TestData = "SurName";
            ACustomer.SurName = TestData;
            Assert.AreEqual(ACustomer.SurName, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {

            clsCustomer ACustomer = new clsCustomer();
            string TestData = "Email";
            ACustomer.Email = TestData;
            Assert.AreEqual(ACustomer.Email, TestData);
        }
        [TestMethod]
        public void AddressPropertyOK()
        {

            clsCustomer ACustomer = new clsCustomer();
            string TestData = "Address";
            ACustomer.Address = TestData;
            Assert.AreEqual(ACustomer.Address, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsCustomer Acustomer = new clsCustomer();
            DateTime TestData = DateTime.Date;
            Acustomer.DateAdded = TestData; 
            Assert.AreEqual(Acustomer.DateAdded, TestData);
        }
        [TestMethod]
        public void ActiveCustomerPropertyOK()
        {

            clsCustomer ACustomer = new clsCustomer();
            Boolean TestData = true;
            ACustomer.Active = TestData;
            Assert.AreEqual(ACustomer.Active, TestData);
        }
    }
    }

