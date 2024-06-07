using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Dynamic;
using System.IO;

namespace Testing4
{
    [TestClass]
    public class tstOrders
    {
        //good test data
        //create some test data to pass the method
        string Dispatched = "yes";
        string DispatchDate = DateTime.Now.ToShortDateString();
        string Price = "129.99";
        string StockItem = "panda dunks";
        string CustomerName = "jaden smith";
        string Description = "these shoes are size 5 mens";
        public object AnCustomerName { get; private set; }
        public object AnStockItem { get; private set; }
        public object AnDescription { get; private set; }


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
        {        
            //create an instance of the class I want to create
            clsOrders AnOrders = new clsOrders();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 OrderID = 3;
            //invoke the method 
            Found = AnOrders.Find(OrderID);
        }
        [TestMethod]
        public void TestDispatchedFound()
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
            Error = AnOrders.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the results is correct
            Assert.AreEqual(Error, Error);
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
            Int32 OrderID = 2;
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
        public void TestCustomerNameFound()
        {
            //create an instance of the class we want 
            clsOrders AnCustomerName = new clsOrders();
            //create a boolean variable to store the reulst
            Boolean Found = false;
            //create a boolean variable to record if data
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 2;
            //invoke the method
            Found = AnCustomerName.Find(OrderID);
            //check the price property
            if (AnCustomerName.CustomerName != "daniel johnson")
            {
                OK = false;
            }

        }
        [TestMethod]
        public void CustomerNameMin()
        {
            //create an insatcne of the class we want to create
            clsOrders AnCustomerName = new clsOrders();
            //string variable to store any error message 
            String Error = "";
            //create some tes data to pass to the method
            CustomerName = CustomerName.PadRight(5, 'a');
            Error = AnCustomerName.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the reulst is correct
            Assert.AreEqual(Error, Error);
        }
       
        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnCustomerName = new clsOrders();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerName = ""; //this method should trigger an error
                                      //invoke a method
            CustomerName = CustomerName.PadRight(4, 'a');
            Error = AnCustomerName.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnCustomerName = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            CustomerName = CustomerName.PadRight(6, 'a');
            Error = AnCustomerName.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, " ");

        }
        [TestMethod]
        public void CustomerNameMid()
        {
            //create an instance of the class we want to create
            clsOrders AnCustomerName = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            CustomerName = CustomerName.PadRight(7, 'a');
            Error = AnCustomerName.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNameMax()
        {
            //create an instance of the class we want to create
            clsOrders AnCustomerName = new clsOrders();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            CustomerName = CustomerName.PadRight(50, 'a');
            Error = AnCustomerName.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the reulst is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnCustomerName = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            CustomerName = CustomerName.PadRight(51, 'a');
            Error = AnCustomerName.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnCustomerName = new clsOrders();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aaaaa"; // this should be ok 
            //invoke the method 
            Error = AnCustomerName.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
        }
        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            //create an instance of the class we want to create 
            clsOrders AnCustomerName = new clsOrders();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(500, 'a'); //this shoud fail

            //invoke the method
            Error = AnCustomerName.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockItemMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnStockItem = new clsOrders();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StockItem = ""; //this method should trigger an error
            //invoke a method
            Error = AnStockItem.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockItemMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnStockItem = new clsOrders();
            //string variable to store any error message 
            String Error = " ";
            //create some test data to pass to the method
            StockItem = StockItem.PadRight(6, 'a');
            Error = AnStockItem.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the reult is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockItemMax()
        {
            //create an instance of the class we want to create
            clsOrders AnStockItem = new clsOrders();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            StockItem = StockItem.PadRight(30, 'a');
            Error = AnStockItem.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the reulst is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockItemMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnStockItem = new clsOrders();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string StockItem = "aaaaa"; // this should be ok 
            //invoke the method 
            Error = AnStockItem.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
        }
        [TestMethod]
        public void StockItemExtremeMax()
        {
            //create an instance of the class we want to create 
            clsOrders AnStockItem = new clsOrders();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string StockItem = "";
            StockItem = StockItem.PadRight(500, 'a'); //this shoud fail
            //invoke the method
            Error = AnStockItem.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockItemMin()
        {
            //create an instance of the class we want to create
            clsOrders AnStockItem = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            StockItem = StockItem.PadRight(5, 'a');
            Error = AnStockItem.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockItemMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnStockItem = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockItem = "aaaaaa"; //this should fail
            //invoke the method
            Error = AnStockItem.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
        }
        [TestMethod]
        public void DescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnDescription = new clsOrders();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Description = ""; //this method should trigger an error
            //invoke a method
            Error = AnDescription.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMin()
        {
            //create an instance of the class we want to create
            clsOrders AnDescription = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "a"; //this should be ok
            //invoke the method
            Error = AnDescription.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnDescription = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            StockItem = StockItem.PadRight(21, 'a');
            Error = AnDescription.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnDescription = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            StockItem = StockItem.PadRight(9, 'a');
            Error = AnDescription.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMax()
        {
            //create an instance of the class we want to create
            clsOrders AnDescription = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Description = Description.PadRight(49, 'a');
            Error = AnDescription.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMid()
        {
            //create an instance of the class we want to create
            clsOrders AnDescription = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Description = Description.PadRight(37, 'a');
            Error = AnDescription.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnDescription = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "aaaaaa"; //this should fail
            //invoke the method
            Error = AnDescription.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
        }
        [TestMethod]
        public void PriceLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnPrice = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Price = Price.PadRight(5, 'a');
            Error = AnPrice.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsOrders AnPrice = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Price = Price.PadRight(6, 'a');
            Error = AnPrice.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnPrice = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Price = Price.PadRight(7, 'a');
            Error = AnPrice.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsOrders AnPrice = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Price = Price.PadRight(10, 'a');
            Error = AnPrice.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMid()
        {
            //create an instance of the class we want to create
            clsOrders AnPrice = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Price = Price.PadRight(7, 'a');
            Error = AnPrice.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnPrice = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "aaaaaa"; //this should fail
            //invoke the method
            Error = AnPrice.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
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
            Error = AnPrice.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /* [TestMethod]
         public void DispatchedLessOne()
         {
             //create an instance of the class we want to create
             clsOrders AnDispatched = new clsOrders();
             //string variable to store any error message
             String Error = "";
             //create some test data to pass to the method
             string Dispatched = "aaaaa"; //this should be ok
             //invoke the method
             Error = AnDispatched.Valid(CustomerName, StockItem, DispatchDate, Description, Price, Dispatched);
             //test to see that the result is correct
             Assert.AreEqual(Error, "");
         }
         [TestMethod]
         public void DispatchedMin()
         {
             //create an instance of the class we want to create
             clsOrders AnDispatched = new clsOrders();
             //string variable to store any error message
             String Error = "";
             //create some test data to pass to the method
             string Dispatched = "a"; //this should be ok
             //invoke the method
             Error = AnDispatched.Valid(CustomerName, StockItem, DispatchDate, Description, Price, Dispatched);
             //test to see that the result is correct
             Assert.AreEqual(Error, "");
         }
         [TestMethod]
         public void DispatchedPlusOne()
         {
             //create an instance of the class we want to create
             clsOrders AnDispatched = new clsOrders();
             //string variable to store any error message
             String Error = "";
             //create some test data to pass to the method
             string Dispatched = "aa"; //this should be ok
             //invoke the method
             Error = AnDispatched.Valid(CustomerName, StockItem, DispatchDate, Description, Price, Dispatched);
             //test to see that the result is correct
             Assert.AreEqual(Error, "");
         }
         [TestMethod]
         public void DispatchedMax()
         {
             //create an instance of the class we want to create
             clsOrders AnDispatched = new clsOrders();
             //string variable to store any error message
             String Error = "";
             //create some test data to pass to the method
             string Dispatched = "aaaaaa"; //this should be ok
             //invoke the method
             Error = AnDispatched.Valid(CustomerName, StockItem, DispatchDate, Description, Price, Dispatched);
             //test to see that the result is correct
             Assert.AreEqual(Error, "");
         }
         [TestMethod]
         public void DispatchedMid()
         {
             //create an instance of the class we want to create
             clsOrders AnDispatched = new clsOrders();
             //string variable to store any error message
             String Error = "";
             //create some test data to pass to the method
             string Dispatched = "aaa"; //this should be ok
             //invoke the method
             Error = AnDispatched.Valid(CustomerName, StockItem, DispatchDate, Description, Price, Dispatched);
             //test to see that the result is correct
             Assert.AreEqual(Error, "");
         }
         [TestMethod]
         public void DispatchedMaxPlusOne()
         {
             //create an instance of the class we want to create
             clsOrders AnDispatched = new clsOrders();
             //string variable to store any error message
             String Error = "";
             //create some test data to pass to the method
             string Dispatched = "aaaaaa"; //this should fail
             //invoke the method
             Error = AnDispatched.Valid(CustomerName, StockItem, DispatchDate, Description, Price, Dispatched);
         }
         [TestMethod]
         public void DispatchedExtremeMax()
         {
             //create an instance of the class we want to create 
             clsOrders AnDispatched = new clsOrders();
             //string variable to store any error message 
             String Error = "";
             //create some test data to pass to the method 
             string Dispatched = "";
             Dispatched = Dispatched.PadRight(500, 'a'); //this shoud fail
             //invoke the method
             Error = AnDispatched.Valid(CustomerName, StockItem, DispatchDate, Description, Price, Dispatched);
             //test to see that the result is correct
             Assert.AreNotEqual(Error, "");
         }*/
        [TestMethod]
        public void DispatchDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrders AnDispatchDate = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnDispatchDate.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DispatchDateLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnDispatchDate = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DispatchDate = TestDate.ToString();
            //invoke the method
            Error = AnDispatchDate.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DispatchDateMin()
        {
            //create an instance of the class we want to create
            clsOrders AnDispatchDate = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string DispatchDate = TestDate.ToString();
            //invoke the method
            Error = AnDispatchDate.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DispatchaDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnDispatchDate = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DispatchDate = TestDate.ToString();
            //invoke the method
            Error = AnDispatchDate.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DispatchDateMax()
        {
            //create an instance of the class we want to create
            clsOrders AnDispatchDate = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DispatchDate = DispatchDate.PadRight(8, 'a');
            Error = AnDispatchDate.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DispatchDateMid()
        {
            //create an instance of the class we want to create
            clsOrders AnDispatchDate = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DispatchDate = DispatchDate.PadRight(7, 'a');
            Error = AnDispatchDate.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DispatchDateMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnDispatchDate = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DispatchDate = "aaaaaa"; //this should fail
            //invoke the method
            Error = AnDispatchDate.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
        }
        [TestMethod]
        public void DispatchDateExtremeMax()
        {
            //create an instance of the class we want to create 
            clsOrders AnDispatchDate = new clsOrders();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable to a string variable 
            string DispatchDate = TestDate.ToString();
            //invoke the method
            Error = AnDispatchDate.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DispatchDateInvalidData()
        {
            //create an instance of the new class we want to create
            clsOrders AnDispatchDate = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //set the dispatcheddate to a non date value
            string DispatchDate = "This is not a date!:";
            //invoke the
            Error = AnDispatchDate.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
            //tes to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
    }
}
