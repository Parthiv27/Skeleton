﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Testing4
{
    [TestClass]
    public class tstOrders
    {
        public object AnCustomerName { get; private set; }
        public object AnStockItem { get; private set; }

        [TestMethod]
        public void instanceOK()
        {
            clsOrders AnOrders = new clsOrders();
            Assert.IsNotNull(AnOrders);
        }
        [TestMethod]

        public void DispatchedPropertyOK()
        {
            clsOrders AnOrders = new clsOrders();

            Boolean TestData = true;

            AnOrders.Dispatched = TestData;

            Assert.AreEqual(AnOrders.Dispatched, TestData);
        }
        public void DateAddedPropertyOK()
        {
            clsOrders AnDispatchDate = new clsOrders();
            DateTime TestData = DateTime.Now.Date;
            AnDispatchDate.DispatchDate = TestData;
            Assert.AreEqual(AnDispatchDate.DispatchDate, TestData);
        }
        [TestMethod]
        public void CustomerNameOK()
        {
            clsOrders AnCustomerName = new clsOrders();
            string TestDate = "Donald Jinadu";
            AnCustomerName.CustomerName = TestDate;
        }
        [TestMethod]
        public void StockItemOK()
        {
            clsOrders AnStockItem = new clsOrders();
            string TestData = "Jordan 4s";
            AnStockItem.StockItem = TestData;
        }

        [TestMethod]
        public void DescriptionOK()
        {
            clsOrders AnDescription = new clsOrders();
            string TestData = " this shoe is a size 4 mens";
            AnDescription.Description = TestData;
        }
        [TestMethod]
        public void PriceOK()
        {
            //create an instance of the class we want to create 
            clsOrders AnPrice = new clsOrders();
            //create sp,e test data to assign to the property
            Double testData = 100.00;
            //assign the data to the property
            AnPrice.Price = testData;
            //test to see that the 2 values are the same
            Assert.AreEqual(testData, AnPrice.Price);
        }


        


        [TestMethod]
        public void FindMethodOK()
        {         //create an instance of the class I want to create
            clsOrders AnOrders = new clsOrders();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 OrderID = 40;
            //invoke the method 
            Found = AnOrders.Find(OrderID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void testDispatchedFound()
        {
            //create an instance of the class we want to create
            clsOrders AnDispatchDate = new clsOrders();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 21;
            //invoke the method
            Found = AnDispatchDate.Find(OrderID);
            //check the dispatch date property
            if (AnDispatchDate.DispatchDate != Convert.ToDateTime("02/06/2004"))
                //always return true
            {
                OK = false;
            }
            [testMethod]
            public void ValidMethodOK()
            {
                //create an instance of the class we want to create 
                clsOrders AnCustomerName = new clsOrders();
                //string variable to store any error message
                string Error = "";
                //invoke method
                Error= AnCustomerName.(Valid(Dispatched,CustomerName,DispatcheDate,Price);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
        }
        
    }
}
