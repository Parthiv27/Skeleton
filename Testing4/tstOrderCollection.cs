using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            //clsOrdersCollection AllOrders = new clsOrdersCollection();
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instacne of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign the property
            // in this case the data needs to be a list of objects
            List<clsOrders> TestList = new List<clsOrders>();
            //add new item to the list
            //create the item of the test data
            clsOrders TestItem = new clsOrders();
            //set its properties
            TestItem.OrderID = 1;
            TestItem.Dispatched = true;
            TestItem.StockItem = "black cats";
            TestItem.Price = 100;
            TestItem.DispatchDate = DateTime.Now;
            TestItem.CustomerName = "Donald Jinadu";
            TestItem.Description = "this shoe is a size 6";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrdersList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrdersList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //creeate some test data to assign to the property 
            clsOrders TestOrders = new clsOrders();
            //set the properties of the test object
            TestOrders.Dispatched = true;
            TestOrders.Price = 100;
            TestOrders.Description = "this shoe is a size 6";
            TestOrders.CustomerName = "Donald Jinadu";
            TestOrders.DispatchDate = DateTime.Now;
            TestOrders.StockItem = "black cats";
            TestOrders.OrderID = 1;
            //assign the data to the property
            AllOrders.ThisOrders = TestOrders;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrders, TestOrders);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want toc reate 
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign to the property 
            //in case the data needs to be a list of objects
            List<clsOrders> TestList = new List<clsOrders>();
            //add an item to the list 
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            TestItem.Dispatched = true;
            TestItem.OrderID = 1;
            TestItem.CustomerName = "michael john";
            TestItem.DispatchDate = DateTime.Now;
            TestItem.StockItem = "black cats";
            TestItem.Price = 100;
            TestItem.Description = "this shoe is a size 6";
            //add the item to the test list Test
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrdersList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create 
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //cariable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Dispatched = true;
            TestItem.OrderID = 1;
            TestItem.DispatchDate = DateTime.Now;
            TestItem.CustomerName = "Donald Jinadu";
            TestItem.StockItem = "black cats";
            TestItem.Price = 100;
            TestItem.Description = "this shoe is a size 6";
            //set thisorders to the test data 
            AllOrders.ThisOrders = TestItem;
            //add the record 
            PrimaryKey = AllOrders.Add();
            //modify the test record 
            TestItem.Dispatched = false;
            TestItem.OrderID = 2;
            TestItem.DispatchDate = DateTime.Now;
            TestItem.CustomerName = "Donald  Jinadu";
            TestItem.StockItem = "black cats";
            TestItem.Price = 150;
            TestItem.Description = "this shoe is a size 6";
            //set the record based on the new test data 
            AllOrders.ThisOrders = TestItem;
            //update the record 
            AllOrders.Update();
            //find the record 
            AllOrders.ThisOrders.Find(PrimaryKey);
            //test to see if thisOrders matches the test data 
            Assert.AreEqual(AllOrders.ThisOrders, TestItem);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create the item of the test data
            clsOrders TestItem = new clsOrders();
            //cariable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Dispatched = false;
            TestItem.OrderID = 2;
            TestItem.DispatchDate = DateTime.Now;
            TestItem.CustomerName = "Donald  Jinadu";
            TestItem.StockItem = "black cats";
            TestItem.Price = 150;
            TestItem.Description = "this shoe is a size 6";
            //set thisorders to the test data
            AllOrders.ThisOrders = TestItem;
            //add the record 
            PrimaryKey = AllOrders.Add();
            //set the primary key of te test data
            TestItem.OrderID = PrimaryKey;
            //Find the record
            AllOrders.ThisOrders.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrders, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Dispatched = true;
            TestItem.DispatchDate = DateTime.Now;
            TestItem.CustomerName = "Donald Jinadu";
            TestItem.StockItem = "black cats";
            TestItem.Price = 100;
            TestItem.Description = "this shoe is a size 6";
            //set thisorders to the test data
            AllOrders.ThisOrders = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key fo the test data
            TestItem .OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrders.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrders.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByCustomerNameMethodOK()
        {
            //create an instance of the class we want toc reate 
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create an instance of the filtered data
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();
            //apply all blank string (it should return all records)
            FilteredOrders.ReportByCustomerName("");
            //testto see that the values are the same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByCustomerNameNoneFound()
        {
            //create an instance of the class we want to create 
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();
            //apply acustomer name that doesnt exist
            FilteredOrders.ReportByCustomerName("xxxxx xxxxxxx");
            //test to see that there are no records 
            Assert.AreEqual(0, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByCustomerNameTestDataFound()
        {
            //create an instance of the filtered data
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a customer name that doesnt exist 
            FilteredOrders.ReportByCustomerName("david johnson");
            //check that the correct nymber of records are found
            if (FilteredOrders.Count == 2)
            {
                //Check to see that the first record is 25
                if (FilteredOrders.OrdersList[0].OrderID != 1)
                {
                    OK = false;
                }
                //check to see that the first record is 26
                if (FilteredOrders.OrdersList[1].OrderID != 2)
                {
                    OK = false;
                }
                else
                {
                    OK = false;
                }
                //test to see that there are no records 
                Assert.IsTrue(OK);
            }         
        }
      


    }
}
