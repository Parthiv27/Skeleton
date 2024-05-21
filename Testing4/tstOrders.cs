using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Testing4
{
    [TestClass]
    public class tstOrders
    {
        //good test data
        //create some test data to pass the method
        string Dispatched = "yes";
        string DispatcheDate = DateTime.Now.ToShortDateString();
        string Price = "129.99";
        string StockItem = "panda dunks";
        string CustomerName = "jaden smith";
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
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            //string variable to store any error message
            string Error = "";
            //invoke the method
            Error = AnOrders.Valid(Dispatched, DispatchDate, Price, StockItem, CustomerName);
            //test to see that the refuls is correct
        }
        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the new class we want
            clsOrders AnOrder = new clsOrders();
            //create a boolean variable to store the result
            Boolean Found = false;
            //create a boolean variable variable to record if
            Boolean OK = true;
            //create some test data to use with the method
            int32 OrderID = 2;
            //invoke method
            Found = AnOrder.Find(OrderID);
            //check the order ID property
            if (AnOrder.OrderID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void testPriceFound()
        {
            //create an instance of the class we want 
            clsOrders AnPrice = new clsOrders();
            //create a boolean variable to store the reulst
            Boolean Found = false;
            //create a boolean variable to record if data
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 2;
            //invoke the method
            Found = AnPrice.Find(OrderID);
            //check the price property
            if (AnPrice.amount != "199.99")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnPrice = new clsOrders();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Price = ""; //this method should trigger an error
            //invoke a method
            Error = AnPrice.Valid(Dispatched, CustomerName, DispatcheDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [testMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnPrice = new clsOrders();
            //string variable to store any error message 
            String Error = " ";
            //create some test data to pass to the method
            string Price = "aa"; //this should be ok
            //invoke the method
            Error = AnPrice.Valid(Dispatched, CustomerName, DispatcheDate);
            //test to see that the reult is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsOrders AnPrice = new clsOrders();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Price = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnPrice.Valid(Dispatched, CustomerName, DispatcheDate);
            //test to see that the reulst is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnPrice = new clsOrders();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Price = "aaaaa"; // this should be ok 
            //invoke the method 
            Error = AnPrice.Valid(Dispatched, CustomerName, DispatcheDate);
        }
        [TestMethod]
        public void PriceExtremeMax()
        {
            //create an instance of the class we want to create 
            clsOrders AnPrice = new clsOrders();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Price = "";
            Price = Price.PadRight(500, 'a'); //this shoud fail
                                              //invoke the method
            Error = AnPrice.Valid(Dispatched, CustomerName, DispatcheDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DispatchDateExtremeMin()
        {
            //create an insatcne of the class we want to create
            clsOrders AnDispatchDate = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateAdded TestDate;
            //set the date to whatever the date is less 100 years
            TestDate = DateAdded.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnDispatchDate.Valid(Dispatched, CustomerName, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
       

    }
}
