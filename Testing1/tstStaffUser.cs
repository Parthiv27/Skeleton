using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaffUser
    {
        [TestMethod]
        public void InstanceOK()
        {   
            //create an inatnce of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //test to see that it exits
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an inatnce of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            AnUser.UserID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //create some test data to assign to the property
            string TestData = "Parthiv1";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //create some test data to assign to the property
            string TestData = "Parthiv123";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
         Assert.AreEqual(AnUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //create some test data to assign to the property
            string TestData = "Staff Department";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }

        //Find Methods /////  //Find Methods /////
        //Find Methods /////  //Find Methods /////

        [TestMethod]
        public void FindUserMethodOK() 
        {
            //create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //create a boolean varibale to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            string UserName = "Parthiv1";
            string Password = "Parthiv123";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            //create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //create a boolean varibale to store the result of the search
            Boolean Found = false;
            //create a boolean varibale to record if the data is ok 
            Boolean OK = true;
            //create some test data to use with the method
            string UserName = "Parthiv1";
            string Password = "Parthiv123";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //chechk the user id prperty
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);

        }
    }
}
