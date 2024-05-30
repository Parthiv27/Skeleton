using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing5
{
    [TestClass]
    public class tstSupplierSupplier
    {
        
            [TestMethod]
            public void InstanceOK()
            {
                clsSupplierUser AnUser = new clsSupplierUser();
                Assert.IsNotNull(AnUser);
            }


            [TestMethod]
            public void UserIDPropertyOK()
            {
                clsSupplierUser AnUser = new clsSupplierUser();
                Int32 TestData = 1;
                AnUser.UserID = TestData;
                Assert.AreEqual(AnUser.UserID, TestData);
            }


            [TestMethod]
            public void UsernamePropertyOK()
            {
                clsSupplierUser AnUser = new clsSupplierUser();
                string TestData = "Ahmad";
                AnUser.Username = TestData;
                Assert.AreEqual(AnUser.Username, TestData);
            }


            [TestMethod]
            public void PasswordPropertyOK()
            {
                clsSupplierUser AnUser = new clsSupplierUser();
                string TestData = "111111";
                AnUser.Password = TestData;
                Assert.AreEqual(AnUser.Password, TestData);
            }



            [TestMethod]
            public void DepartmentPropertyOK()
            {
                clsSupplierUser AnUser = new clsSupplierUser();
                string TestData = "Suppliers Department";

                AnUser.Department = TestData;
                Assert.AreEqual(AnUser.Department, TestData);
            }

            [TestMethod]

            public void FindUserMethodOK()
            {
                clsSupplierUser AnUser = new clsSupplierUser();
                Boolean Found = false;
                string Username = "Ahmad Faraz";
                string Password = "12345";
                Found = AnUser.FindUser(Username, Password);
                Assert.IsTrue(Found);
            }

            [TestMethod]

            public void TestUsernamePWFound()
            {
                clsSupplierUser AnUser = new clsSupplierUser();
                Boolean Found = false;
                Boolean Ok = true;
                string Username = "Ahmad Faraz";
                string Password = "12345";
                Found = AnUser.FindUser(Username, Password);

                if (AnUser.Username != Username && AnUser.Password != Password)
                {
                    Ok = false;
                }
                Assert.IsTrue(Ok);
        }
    }
}
