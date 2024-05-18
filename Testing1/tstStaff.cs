using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        //good test data
        //creat some test data to pass the method
        string FirstName = "James";
        string LastName = "Smith";
        string Email = "JamesSmith@gmail.com";
        string HireDate = DateTime.Now.ToShortDateString();
        string Salary = "25000";

        public object txtFirstName { get; private set; }
        public object chkActive { get; private set; }
        public int Checked { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instanece of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AnStaff);
        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStaff.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffId, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "FirstName";
            //assign the data to the property
            AnStaff.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "LastName";
            //assign the data to the property
            AnStaff.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.LastName, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Email";
            //assign the data to the property
            AnStaff.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Email, TestData);
        }

        [TestMethod]
        public void HireDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStaff.HireDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.HireDate, TestData);
        }

        [TestMethod]
        public void ActiveStaffPropertyOK()
        {
            //create an instanece of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //creat some test  data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStaff.Active = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnStaff.Active, TestData);
        }
        [TestMethod]
        public void SalaryPropertyOK()
        {
            //create an instanece of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //creat some test  data to assign to the property
            Decimal TestData = 50000;
            //assign the data to the property
            AnStaff.Salary = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnStaff.Salary, TestData);
        }

        [TestMethod]
        public void FindMethoOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //test to see if the result is true 
            Assert.IsTrue(Found);
        }

        /******************PROPERTY DATA TESTS******************/
        /******************PROPERTY DATA TESTS******************/
        /******************PROPERTY DATA TESTS******************/


        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the Staff id property
            if (AnStaff.StaffId != 1)
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
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the Staff firstname property
            if (AnStaff.FirstName != "James")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the lastname property
            if (AnStaff.LastName != "Smith")
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
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the email property
            if (AnStaff.Email != "JamesSmith@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestHireDateFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the  hiredate property
            if (AnStaff.HireDate != Convert.ToDateTime("12/04/2023"))
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
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff active  property
            if (AnStaff.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestSalaryFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff salary  property
            if (AnStaff.Salary != Convert.ToDecimal("25000"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        //Validation Methods // //Validation Methods //
        //Validation Methods // //Validation Methods //
        //Validation Methods // //Validation Methods //
        //Validation Methods // //Validation Methods //

        //First Validation Methods

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string varibale to store any error message
            String Error = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string c=varibale to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string FirstName = ""; //this should trigger an error
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "a"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaa"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'a'); //this shoudl fail
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //Second Validation Methods//

        [TestMethod]
        public void HireDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string HireDate = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void HireDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string HireDate = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void HireDateMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string HireDate = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string HireDate = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string HireDate = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void HireDateInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the HireAdded to non date value
            string HireDate = "this is not a date!";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //Third Validation Methods//
        //Third Validation Methods//
        
        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string LastName = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "a";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "aa";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "aaaaaaaa";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
            
            [TestMethod]
            public void LastNameMax()
            {
                //create an instance of the class we want to create
                clsStaff AnStaff = new clsStaff();
                //string variable to store any error message
                String Error = "";
                //this should pass
                string LastName = "aaaaaaaaa";
                //invoke the method
                Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void LastNameMaxPlusOne()
            {
                //create an instance of the class we want to create
                clsStaff AnStaff = new clsStaff();
                //string variable to store any error message
                String Error = "";
                //this should fail
                string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaaa";
                //invoke the method
                Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
            [TestMethod]
            public void LastNameMid()
            {
                //create an instance of the class we want to create
                clsStaff AnStaff = new clsStaff();
                //string variable to store any error message
                String Error = "";
                //this should pass
                string LastName = "aaaa";
                //invoke the method
                Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }

        // 4 Mthods //4 Methods//

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Email = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "a";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "aa";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(49, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(50, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Email = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        // 5th Methods // 5th Methods //

        [TestMethod]
        public void SalaryMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Salary = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SalaryMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Salary = "a";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SalaryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Salary = "aa";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SalaryMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Salary = "";
            Salary = Salary.PadRight(49, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SalaryMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Salary = "";
            Salary = Salary.PadRight(50, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string Salary = "";
            Salary = Salary.PadRight(51, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SalaryMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Salary = "";
            Salary = Salary.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Email, HireDate, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }




    }
}
