﻿using ClassLibrary;
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
        
    }
}
