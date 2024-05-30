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
            TestItem.StockItem = "jordan 4s";
            TestItem.Price = 100;
            TestItem.DispatchDate = DateTime.Now;
            TestItem.CustomerName = "Donald Jinadu";
            TestItem.Description = " this shoe is black and white on the bottom";
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
            TestOrders.Description = "Description";
            TestOrders.CustomerName = "david shmiechal";
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
            TestItem.StockItem = " militant reds";
            TestItem.Price = 100;
            //add the item to the test list Test
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrdersList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

    }
}
