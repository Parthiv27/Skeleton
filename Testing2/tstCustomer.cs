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
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerId, TestData);
        }
        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "FirstName";
            //assign the data to the property
            ACustomer.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }
        [TestMethod]
        public void CustomerSurNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "SurName";
            //assign the data to the property
            ACustomer.SurName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.SurName, TestData);
        }
        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Email";
            //assign the data to the property
            ACustomer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Address, TestData);
        }
        [TestMethod]
        public void DateJoinedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.DateJoined = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateJoined, TestData);

        }
        [TestMethod]
        public void ActiveCustomerPropertyOK()
        {
            //create an instanece of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //creat some test  data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ACustomer.Active = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(ACustomer.Active, TestData);
        }
        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Address";
            //assign the data to the property
            ACustomer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Address, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerId = 4;
            Found = ACustomer.Find(CustomerId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestDateJoinedFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the datais ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 4;
            //invike the method
            Found = ACustomer.Find(CustomerId);
            //check the customer id
            if (ACustomer.DateJoined != Convert.ToDateTime("02/06/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the datais ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 4;
            //invike the method
            Found = ACustomer.Find(CustomerId);
            //check the customer id
            if (ACustomer.FirstName != "Joe")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSurNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the datais ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 4;
            //invike the method
            Found = ACustomer.Find(CustomerId);
            //check the customer id
            if (ACustomer.SurName != "BIDEN")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the datais ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 4;
            //invike the method
            Found = ACustomer.Find(CustomerId);
            //check the customer id
            if (ACustomer.Email != "joe4@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the datais ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 4;
            //invike the method
            Found = ACustomer.Find(CustomerId);
            //check the customer id
            if (ACustomer.Address != "7 broadway")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the datais ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 4;
            //invike the method
            Found = ACustomer.Find(CustomerId);
            //check the customer id
            if (ACustomer.Active != false)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the datais ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 4;
            //invike the method
            Found = ACustomer.Find(CustomerId);
            //check the customer id
            if (ACustomer.CustomerId != 4)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



    }

}



