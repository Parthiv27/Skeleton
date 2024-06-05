using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);

        }
        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign the property
            //in this case data needs to be alist of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an item to the list
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.FirstName = "Joe";
            TestItem.SurName = "Biden";
            TestItem.Active = false;
            TestItem.Email = "joe4@gmail.com";
            TestItem.Address = "7 broadway";
            TestItem.DateJoined = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }
             
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create the item of the test data
            clsCustomer TestCustomer = new clsCustomer();
            //set its properties
            TestCustomer.FirstName = "Joe";
            TestCustomer.SurName = "Biden";
            TestCustomer.Active = false;
            TestCustomer.Email = "joe4@gmail.com";
            TestCustomer.Address = "7 broadway";
            TestCustomer.DateJoined = DateTime.Now;

            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign the property
            //in this case data needs to be alist of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an item to the list
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.FirstName = "Ehsan";
            TestItem.SurName = "Ijaz";
            TestItem.Active = true;
            TestItem.Email = "ehsan12@gmail.com";
            TestItem.Address = "1 london road";
            TestItem.DateJoined = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //Add an item to the list
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.FirstName = "Ehsan";
            TestItem.SurName = "Ijaz";
            TestItem.Active = true;
            TestItem.Email = "ehsan12@gmail.com";
            TestItem.Address = "1 london road";
            TestItem.DateJoined = DateTime.Now;
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //Add an item to the list
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();

            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.FirstName = "Ehsan";
            TestItem.SurName = "Ijaz";
            TestItem.Active = true;
            TestItem.Email = "ehsan12@gmail.com";
            TestItem.Address = "1 london road";
            TestItem.DateJoined = DateTime.Now;
            AllCustomers.ThisCustomer = TestItem;

            // set this staff to test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record 
            PrimaryKey = AllCustomers.Add();
            //set the parimary key  of of test data
            TestItem.CustomerId = PrimaryKey;
            //modify the test record
            //set its properties
            TestItem.FirstName = "Ehsan123";
            TestItem.SurName = "Ijaz123";
            TestItem.Active = true;
            TestItem.Email = "ehsan11322@gmail.com";
            TestItem.Address = "122 london road";
            TestItem.DateJoined = DateTime.Now;
            AllCustomers.ThisCustomer = TestItem;
            // set this staff to test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record 
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test  to see that the two values are same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //Add an item to the list
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.FirstName = "Ehan";
            TestItem.SurName = "Ijz";
            TestItem.Active = true;
            TestItem.Email = "ehsan1@gmail.com";
            TestItem.Address = "1 londo road";
            TestItem.DateJoined = DateTime.Now;
            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //DELETE THE RECORD
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not founmd
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByFirstNameMethodOK()
        {
            // create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            //apply a balnk string(should retuen all record);
            FilteredCustomer.ReportByFirstName("");
            //test to see that the two value are the same
            Assert.AreEqual(AllCustomer.Count, FilteredCustomer.Count);
        }

        [TestMethod]
        public void ReportByFirstNameNoneFound()
        {
            // create an instance of the class we want to create
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            //apply a first name that doesnt exits
            FilteredCustomer.ReportByFirstName("YYYYYY");
            //test to see that there are no record
            Assert.AreEqual(0, FilteredCustomer.Count);
        }

        [TestMethod]
        public void ReportByFirstNameTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a first name that exists in your dataset
            FilteredCustomer.ReportByFirstName("Ehsan123");
            //check the correct number of records found
            if (FilteredCustomer.Count == 2)
            {
                //check the record if the first record is 47
                if (FilteredCustomer.CustomerList[0].CustomerId != 6)
                {
                    OK = false;
                }
                //check to see that the second record is 90
                if (FilteredCustomer.CustomerList[1].CustomerId != 7)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are the expected records
            Assert.IsTrue(OK);
        }
    }
}
