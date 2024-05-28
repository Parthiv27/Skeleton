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
            Int32 SomeCount = 0;
            AllSupplier.Count = SomeCount;
            Assert.AreEqual(AllSupplier.Count, SomeCount);
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


        [TestMethod]
        public void AddMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestSupplier.SupplierName = "Ahmad Faraz";
            TestSupplier.Email = "ahmad@gmail.com";
            TestSupplier.Phone = "11111111112";
            TestSupplier.Active = false;
            TestSupplier.DateReg = DateTime.Now.Date;
            AllSuppliers.ThisSupplier = TestSupplier;
            PrimaryKey = AllSuppliers.Add();
            TestSupplier.SupplierID = PrimaryKey;
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);

        }

        [TestMethod]
        public void EditMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestSupplier.SupplierName = "Ahmad Faraz";
            TestSupplier.Email = "ahmad@gmail.com";
            TestSupplier.Phone = "11111111112";
            TestSupplier.Active = false;
            TestSupplier.DateReg = DateTime.Now.Date;

            AllSuppliers.ThisSupplier = TestSupplier;

            PrimaryKey = AllSuppliers.Add();
            TestSupplier.SupplierID = PrimaryKey;
            TestSupplier.SupplierName = "AHMAD Faraz";
            TestSupplier.Email = "ahmad@Hotmail.com";
            TestSupplier.Phone = "111111999912";
            TestSupplier.Active = true;
            TestSupplier.DateReg = DateTime.Now.Date;

            AllSuppliers.ThisSupplier = TestSupplier;
            AllSuppliers.Update();
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();
            Int32 PrimaryKey = 0;

            TestSupplier.SupplierID = PrimaryKey;
            TestSupplier.SupplierName = "Ahmad Faraz";
            TestSupplier.Email = "ahmad@gmail.com";
            TestSupplier.Phone = "11111111112";
            TestSupplier.Active = false;
            TestSupplier.DateReg = DateTime.Now.Date;
            AllSuppliers.ThisSupplier = TestSupplier;
            PrimaryKey = AllSuppliers.Add();
            TestSupplier.SupplierID = PrimaryKey;
            AllSuppliers.ThisSupplier.Find(PrimaryKey);

            AllSuppliers.Delete();
            Boolean Found = AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }



        [TestMethod]
        public void ReportBySuppliernameMethodOK()
        {

            clsSupplierCollection AllSuppliers = new clsSupplierCollection();

            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            FilteredSuppliers.ReportBySupplierEmail("");

            Assert.AreEqual(AllSuppliers.Count, FilteredSuppliers.Count);


        }

        [TestMethod]
        public void ReportBySuppliernameNoneFound()
        {
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            FilteredSuppliers.ReportBySupplierEmail("samar@gmail.com");
            Assert.AreEqual(0, FilteredSuppliers.Count);
        }


        [TestMethod]

        public void ReportBySuppliernameTestDataFound()
        {
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            Boolean OK = true;
            FilteredSuppliers.ReportBySupplierEmail("Samar Hayat");
            if (FilteredSuppliers.Count == 2)
            {
                if (FilteredSuppliers.SupplierList[0].SupplierID != 24)
                {
                    OK = false;
                }
                if (FilteredSuppliers.SupplierList[0].SupplierID != 25)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }


    }
}
