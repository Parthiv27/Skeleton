using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        //private data member for the list
        private List<clsOrders> mOrdersList;

        //public property for the address list
        public List <clsOrders> OrderList
        {
            get
            {
                //return the private data
                return mOrdersList;
            }
            set
            {
                //set the private data
                mOrdersList = value;
            }
        }    
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrdersList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsOrders ThisOrders { get; set; }
        
    }

    public clsOrdersCollection()
    {

        //create the items of the test data 
        clsOrders TestItem = new clsOrders();
        //set its properties
        TestItem.Dispatched = true;
        TestItem.OrderID = 1;
        TestItem.CustomerName = "evans abahigwe";
        TestItem.StockItem = "black cats";
        TestItem.Description = "black and white shoes";
        TestItem.DispatchDate = DateTime.Now;
        TestItem.Price = 100;
        //Add the test item to the test list
        mOrdersList.Add(TestItem);
        //re initialise the object for some new data
        TestItem = new clsOrders();
        //set its properties
        TestItem.Dispatched = true;
        TestItem.OrderID = 2;
        TestItem.CustomerName = "evans abahigwe";
        TestItem.Description = "black and white shoes";
        TestItem.DispatchDate = DateTime.Now;
        TestItem.StockItem = "black cats";
        TestItem.Price = 100;
        //add the item to the test list
        mOrderList.Add(TestItem);
    }
}