using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStockUser
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create 
            clsStockUser AnUser = new clsStockUser();

            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIdPropertyOK()
        {
            clsStockUser AnUser = new clsStockUser();

            Int32 TestData = 1;

            AnUser.UserId = TestData;

            Assert.AreEqual(AnUser.UserId, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();            
            //create some test data to assign to the property
            string TestData = "Mihir";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();            
            //create some test data to assign to the property
            string TestData = "Mihir1234";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();            
            //create some test data to assign to the property
            string TestData = "Stock Department";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }


        //Find Methods /////  //Find Methods /////

        [TestMethod]

        public void FindUserMethodOK()
        {
            clsStockUser AnUser = new clsStockUser();

            Boolean Found = false;

            string Username = "Mihir";
            string Password = "Mihir1234";

            Found = AnUser.FindUser(Username, Password);

            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestUserNamePWFound()
        {
            clsStockUser AnUser = new clsStockUser();

            Boolean Found = false;

            Boolean OK = true;

            string Username = "Mihir";
            string Password = "Mihir1234";

            Found = AnUser.FindUser(Username, Password);

            if (AnUser.UserName != Username && AnUser.Password != Password)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }





    }
}
