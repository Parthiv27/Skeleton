using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an intance of the class we want to cerate
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that is exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objets
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an item to the list
            //create the items of test data 
            clsStaff TestItem = new clsStaff();
            //Set it propertise
            TestItem.StaffId = 1;
            TestItem.FirstName = "James";
            TestItem.LastName = "Smith";
            TestItem.Email = "JamesSmith@gmail.com";
            TestItem.HireDate = DateTime.Now;
            TestItem.Active = true;
            TestItem.Salary = 25000;

            //add the item to test lsit
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test  to see that the two values are same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();

            //create some test data to assign to the property 
            clsStaff TestStaff = new clsStaff();

            //Set it propertise
            TestStaff.StaffId = 1;
            TestStaff.FirstName = "James";
            TestStaff.LastName = "Smith";
            TestStaff.Email = "JamesSmith@gmail.com";
            TestStaff.HireDate = DateTime.Now;
            TestStaff.Active = true;
            TestStaff.Salary = 25000;

            //assign the data to property
            AllStaff.ThisStaff = TestStaff;

            //test  to see that the two values are same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create data to assign to the property
            //data need to be list of objects
            List<clsStaff> TestList = new List<clsStaff>();

            //Add items to the list 
            //create the items of test data
            clsStaff TestItem = new clsStaff();

            //Set it propertise
            TestItem.StaffId = 1;
            TestItem.FirstName = "James";
            TestItem.LastName = "Smith";
            TestItem.Email = "JamesSmith@gmail.com";
            TestItem.HireDate = DateTime.Now;
            TestItem.Active = true;
            TestItem.Salary = 25000;

            //Add the itesm to the list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            // Arrange
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.FirstName = "Harry";
            TestItem.LastName = "Potter";
            TestItem.Email = "HarryPotter@gmail.com";
            TestItem.HireDate = DateTime.Now;
            TestItem.Active = true;
            TestItem.Salary = 45000;

            // set this staff to test data
            AllStaff.ThisStaff = TestItem;
            //add the record 
            PrimaryKey = AllStaff.Add();
            //set the parimary key  of of test data
            TestItem.StaffId = PrimaryKey;
            //find the reord
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test  to see that the two values are same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // Arrange
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.FirstName = "Harry";
            TestItem.LastName = "Potter";
            TestItem.Email = "HarryPotter@gmail.com";
            TestItem.HireDate = DateTime.Now;
            TestItem.Active = true;
            TestItem.Salary = 45000;

            // set this staff to test data
            AllStaff.ThisStaff = TestItem;
            //add the record 
            PrimaryKey = AllStaff.Add();
            //set the parimary key  of of test data
            TestItem.StaffId = PrimaryKey;
            //modify the test record
            //set its properties
            TestItem.FirstName = "Rene";
            TestItem.LastName = "Fisher";
            TestItem.Email = "Rf@gmail.com";
            TestItem.HireDate = DateTime.Now;
            TestItem.Active = true;
            TestItem.Salary = 35000;
            //set the record baesd on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record 
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test  to see that the two values are same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffId = 47;
            TestItem.FirstName = "Harry";
            TestItem.LastName = "Potter";
            TestItem.Email = "HarryPotter@gmail.com";
            TestItem.HireDate = DateTime.Now;
            TestItem.Active = true;
            TestItem.Salary = 45000;

            // set this staff to test data
            AllStaff.ThisStaff = TestItem;
            //add the record 
            PrimaryKey = AllStaff.Add();
            //set the parimary key  of of test data
            TestItem.StaffId = PrimaryKey;
            //find the reord
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByFirstNameMethodOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // Populate AllStaff with all records (by passing an empty string to load all records)
            AllStaff.ReportByFirstName("");
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a balnk string(should retuen all record);
            FilteredStaff.ReportByFirstName("");
            //test to see that the two value are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByFirstNameNoneFound()
        {
            // create an instance of the class we want to create
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a first name that doesnt exits
            FilteredStaff.ReportByFirstName("YYY YYY");
            //test to see that there are no record
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByFirstNameTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a first name that doenst exits
            FilteredStaff.ReportByFirstName("YYY YYY");
            //check the record correct number of record found
            if (FilteredStaff.Count == 2)
            {
                //check the record if the first record is 47
                if (FilteredStaff.StaffList[0].StaffId != 47)
                {
                    OK = false;

                }
                //check to see that the first record is 90
                if (FilteredStaff.StaffList[1].StaffId != 90)
                {
                    OK = false;
                }
            }
            else 
            { 
                OK = false; 
            }    

            //test to see there are no record
            Assert.IsTrue(OK);

        }
    }
}




