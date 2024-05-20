using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Diagnostics;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {

        string SupplierName = "abc";
        string Email = "abc@gmail.com";
        string Phone = "001234548785";
        string DateReg = DateTime.Now.Date.ToShortDateString();
        Boolean Active = false;


        //////////////////////////// Property OK Tests /////////////////////////////////
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Assert.IsNotNull(ASupplier);
        }

        [TestMethod]
        public void SupplierIDPropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Int32 TestData = 1;
            ASupplier.SupplierID = TestData;
            Assert.AreEqual(ASupplier.SupplierID, TestData);
        }

        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            String TestData = "Supplier Name";
            ASupplier.SupplierName = TestData;
            Assert.AreEqual(ASupplier.SupplierName, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            String TestData = "abc@gmail.com";
            ASupplier.Email = TestData;
            Assert.AreEqual(ASupplier.Email, TestData);
        }


        [TestMethod]
        public void PhonePropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            String TestData = "0123456789";
            ASupplier.Phone = TestData;
            Assert.AreEqual(ASupplier.Phone, TestData);
        }
        
        [TestMethod]
        public void DateRegPropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            ASupplier.DateReg = TestData;
            Assert.AreEqual(ASupplier.DateReg, TestData);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean TestData = true;
            ASupplier.Active = TestData;
            Assert.AreEqual(ASupplier.Active, TestData);
        }


        //////////////////////////// Find Method Tests /////////////////////////////////

        [TestMethod]
        public void FindMethodOK()
        {

            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Int32 SupplierID = 3;
            Found = ASupplier.Find(SupplierID);
            Assert.IsTrue(Found);

        }

        //////////////////////////// Property Data Tests /////////////////////////////////

        [TestMethod]
        public void TestSupplierIDFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SuppierID = 3;
            Found = ASupplier.Find(SuppierID);
            if (ASupplier.SupplierID != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierNameFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SuppierID = 3;
            Found = ASupplier.Find(SuppierID);
            if (ASupplier.SupplierName != "Supplier C")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestEmailFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SuppierID = 3;
            Found = ASupplier.Find(SuppierID);
            if (ASupplier.Email != "supplierC@example.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestPhoneFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SuppierID = 3;
            Found = ASupplier.Find(SuppierID);
            if (ASupplier.Phone != "555-123-4567")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDateRegFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SuppierID = 3;
            Found = ASupplier.Find(SuppierID);
            if (ASupplier.DateReg != DateTime.Now.Date)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestActiveFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SuppierID = 3;
            Found = ASupplier.Find(SuppierID);
            if (ASupplier.Active != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //////////////////////////// Valid Method Tests /////////////////////////////////

        [TestMethod]
        public void ValidMethodOK()
        {
            clsSupplier ASuppier = new clsSupplier();
            String Error = "";
            Error = ASuppier.Valid(SupplierName, Email, Phone, DateReg, Active);
            Assert.AreEqual(Error, "");
        }


        //////////////////////////// SupplierName validation/////////////////////////////////



        [TestMethod]
        public void SupplierNameMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String SupplierName = "";
            Error = ASupplier.Valid(SupplierName, Email, Phone, DateReg, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierNameMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String SupplierName = "s";
            Error = ASupplier.Valid(SupplierName, Email, Phone, DateReg, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierNameMinPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String SupplierName = "ss";
            Error = ASupplier.Valid(SupplierName, Email, Phone, DateReg, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String SupplierName = "";
            SupplierName = SupplierName.PadRight(19, 's');
            Error = ASupplier.Valid(SupplierName, Email, Phone, DateReg, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierNameMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String SupplierName = "";
            SupplierName = SupplierName.PadRight(20, 's');
            Error = ASupplier.Valid(SupplierName, Email, Phone, DateReg, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String SupplierName = "";
            SupplierName = SupplierName.PadRight(21, 's');
            Error = ASupplier.Valid(SupplierName, Email, Phone, DateReg, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierNameMid()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String SupplierName = "";
            SupplierName = SupplierName.PadRight(10, 's');
            Error = ASupplier.Valid(SupplierName, Email, Phone, DateReg, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String SupplierName = "";
            SupplierName = SupplierName.PadRight(200, 's');
            Error = ASupplier.Valid(SupplierName, Email, Phone, DateReg, Active);
            Assert.AreEqual(Error, "");
        }



        //////////////////////////// Phone validation/////////////////////////////////



        [TestMethod]
        public void PhoneMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String Phone = "12345";
            Error = ASupplier.Valid(SupplierName, Email, Phone, DateReg, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String Phone = "123456";
            Error = ASupplier.Valid(SupplierName, Email, Phone, DateReg, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneMinPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String Phone = "1234567";
            Error = ASupplier.Valid(SupplierName, Email, Phone, DateReg, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneMaxLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String Phone = "12345678910121";
            Error = ASupplier.Valid(SupplierName, Email, Phone, DateReg, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String Phone = "123456789101213";
            Error = ASupplier.Valid(SupplierName, Email, Phone, DateReg, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String Phone = "1234567891012135";
            Error = ASupplier.Valid(SupplierName, Email, Phone, DateReg, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneMid()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String Phone = "1234567";
            Error = ASupplier.Valid(SupplierName, Email, Phone, DateReg, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String Phone = "";
            Phone = Phone.PadRight(100, '1');
            Error = ASupplier.Valid(SupplierName, Email, Phone, DateReg, Active);
            Assert.AreEqual(Error, "");
        }

        //////////////////////////// DateReg validation/////////////////////////////////



        [TestMethod]
        public void DateRegExtremeMinimum()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);

            string DateReg = TestDate.ToString();
            Error = ASupplier.Valid(SupplierName, Email, Phone, DateReg, Active);

            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateRegMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);

            string DateReg = TestDate.ToString();
            Error = ASupplier.Valid(SupplierName, Email, Phone, DateReg, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateRegMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;

            string DateReg = TestDate.ToString();
            Error = ASupplier.Valid(SupplierName, Email, Phone, DateReg, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateRegMinPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);

            string DateReg = TestDate.ToString();
            Error = ASupplier.Valid(SupplierName, Email, Phone, DateReg, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateRegExtremeMaximum()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);

            string DateReg = TestDate.ToString();
            Error = ASupplier.Valid(SupplierName, Email, Phone, DateReg, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateRegInvalidDataType()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";


            string DateReg = "This is not a Valid Date Data Type.";
            Error = ASupplier.Valid(SupplierName, Email, Phone, DateReg, Active);
            Assert.AreEqual(Error, "");
        }

    }

}
