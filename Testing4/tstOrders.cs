using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrders
    {
        [TestMethod]
        public void instanceOK()
        {
            clsOrders AnOrders = new clsOrders();
            Assert.IsNotNull(AnOrders);
        }
        [TestMethod]

        public void ActivePropertyOK()
        {
            clsOrders AnOrders = new clsOrders();

            Boolean TestData = true;

            AnOrders.Active = TestData;

            Assert.AreEqual(AnOrders.Active, TestData);
        }
        public void DateAddedPropertyOK()
        {
            clsOrders AnDispatchDate = new clsOrders();
            DateTime TestData = DateTime.Now.Date;
            AnDispatchDate.DateAdded = TestData;
            Assert.AreEqual(AnDispatchDate.DateAdded, TestData);
        }
        [TestMethod]
        public void FirstNameOK()
        {
            clsOrders AnFirstName = new clsOrders();
            string TestData = "Donald";
            AnFirstName.FirstName = TestData;     
        }
        [TestMethod]
        public void PostCodeOK()
        {
            clsOrders AnPostCode = new clsOrders();
            string TestData = "DA12 5UB";
            AnPostCode.PostCode = TestData;
            Assert.AreEqual(AnPostCode.PostCode,  TestData);
        }
        [TestMethod]
        public void SurnameOK()
        {
            clsOrders AnSurname = new clsOrders();
            string TestDate = "Jinadu";
            AnSurname.Surname = TestDate;
        }
        [TestMethod]
        public void ShoeOK()
        {
            clsOrders AnShoe = new clsOrders();
            string TestData = "Jordan 4s";
            AnShoe.Shoe = TestData;
        }
        [testMethod]
        public void FindMethodOK()
        {         //create an instance of the class I want to create
            clsOrders AnOrders = new clsOrders();
            //create a boolean variable to store the results of the validation
            Boolean found = false;
            //create some test data to use with the method 
            Int32 OrderID = 40;
            //invoke the method 
            Found = AnOrders.Find(OrderID);
            //test to see if the result is true
            Assert.IsTrue(found);
        }
        
    }
}
