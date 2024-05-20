using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            Assert.IsNotNull(AllSuppliers);

        }


        [TestMethod]
        public void SupplierListOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();

            TestItem.SupplierID = 1;
            TestItem.SupplierName= "Name of the supplier";
            TestItem.Email = "abc@gmail.com";
            TestItem.Phone = "0123456789";
            TestItem.Active = true;
            TestItem.DateReg = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllSuppliers.SupplierList = TestList;

            Assert.AreEqual(AllSuppliers.SupplierList, TestList);

        }



        [TestMethod]
        public void CountPropertyOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            Int32 nCount = 0;
            AllSupplier.Count = nCount;
            Assert.AreEqual(AllSupplier.Count, nCount);
        }

        [TestMethod]
        public void ThisProductPropertyOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();

            TestItem.SupplierID = 1;
            TestItem.SupplierName = "Name of the supplier";
            TestItem.Email = "abc@gmail.com";
            TestItem.Phone = "0123456789";
            TestItem.Active = true;
            TestItem.DateReg = DateTime.Now.Date;


            AllSupplier.ThisSupplier = TestItem;

            Assert.AreEqual(AllSupplier.ThisSupplier, TestItem);
        }




        public void ListAndCountOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();

            TestItem.SupplierID = 1;
            TestItem.SupplierName = "Name of the supplier";
            TestItem.Email = "abc@gmail.com";
            TestItem.Phone = "0123456789";
            TestItem.Active = true;
            TestItem.DateReg = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllSupplier.SupplierList = TestList;

            Assert.AreEqual(AllSupplier.Count, TestList.Count);
        }


        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsSupplierCollection AllSupplier= new clsSupplierCollection();
            Assert.AreEqual(AllSupplier.Count, 2);
        }
    }
}
