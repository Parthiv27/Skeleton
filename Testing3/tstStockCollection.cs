using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
        public object SomeCount { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();

            Assert.IsNotNull(AllStocks);
        }

        [TestMethod]

        public void StockListOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();


            List<clsStock> TestList = new List<clsStock>();


            clsStock Testitem = new clsStock();

            Testitem.StockId = 1;
            Testitem.Producttype = "sneaker";
            Testitem.Size = "8";
            Testitem.StockQuantity = 5;
            Testitem.Restockneeded = true;
            Testitem.Daterestocked = DateTime.Now;
            Testitem.Discontinued = false;

            TestList.Add(Testitem);

            AllStocks.StockList = TestList;

            Assert.AreEqual(AllStocks.StockList, TestList);

        }

        
        

        [TestMethod]

        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();


            clsStock TestStock = new clsStock();


            TestStock.StockId = 1;
            TestStock.Producttype = "sneaker";
            TestStock.Size = "8";
            TestStock.StockQuantity = 5;
            TestStock.Restockneeded = true;
            TestStock.Daterestocked = DateTime.Now;
            TestStock.Discontinued = false;

            AllStocks.ThisStock = TestStock;

            Assert.AreEqual(AllStocks.ThisStock, TestStock);

        }

        [TestMethod]

        public void ListAndCountOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();


            List<clsStock> TestList = new List<clsStock>();

            clsStock Testitem = new clsStock();

            Testitem.StockId = 1;
            Testitem.Producttype = "sneaker";
            Testitem.Size = "8";
            Testitem.StockQuantity = 5;
            Testitem.Restockneeded = true;
            Testitem.Daterestocked = DateTime.Now;
            Testitem.Discontinued = false;

            TestList.Add(Testitem);

            AllStocks.StockList = TestList;

            Assert.AreEqual(AllStocks.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection Allstocks = new clsStockCollection();

            clsStock Testitem = new clsStock();

            Int32 PrimaryKey = 0;

            Testitem.StockId = 1;
            Testitem.Producttype = "sneaker";
            Testitem.Size = "8";
            Testitem.StockQuantity = 5;
            Testitem.Restockneeded = true;
            Testitem.Daterestocked = DateTime.Now;
            Testitem.Discontinued = false;

            Allstocks.ThisStock = Testitem;

            PrimaryKey = Allstocks.Add();

            Testitem.StockId = PrimaryKey;

            Allstocks.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(Allstocks.ThisStock, Testitem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();

            clsStock Testitem = new clsStock();

            Int32 PrimaryKey = 0;

            Testitem.Producttype = "sneaker";
            Testitem.Size = "8";
            Testitem.StockQuantity = 5;
            Testitem.Restockneeded = true;
            Testitem.Daterestocked = DateTime.Now;
            Testitem.Discontinued = false;

            AllStocks.ThisStock = Testitem;

            PrimaryKey = AllStocks.Add();

            Testitem.StockId = PrimaryKey;

            Testitem.Producttype = "somesneakerss";
            Testitem.Size = "11";
            Testitem.StockQuantity = 8;
            Testitem.Restockneeded = false;
            Testitem.Daterestocked = DateTime.Now;
            Testitem.Discontinued = true;

            AllStocks.ThisStock = Testitem;

            AllStocks.Update();

            AllStocks.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(AllStocks.ThisStock, Testitem);

        }

        [TestMethod]

        public void DeleteMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();

            clsStock Testitem = new clsStock();

            Int32 PrimaryKey = 0;

            Testitem.StockId = 1;
            Testitem.Producttype = "sneaker";
            Testitem.Size = "8";
            Testitem.StockQuantity = 5;
            Testitem.Restockneeded = true;
            Testitem.Daterestocked = DateTime.Now;
            Testitem.Discontinued = false;

            AllStocks.ThisStock = Testitem;

            PrimaryKey = AllStocks.Add();

            Testitem.StockId = PrimaryKey;

            AllStocks.ThisStock.Find(PrimaryKey);

            AllStocks.Delete();

            Boolean Found = AllStocks.ThisStock.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }

        [TestMethod]

        public void ReportByProducttypeMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();

            clsStockCollection FilteredStocks = new clsStockCollection();

            FilteredStocks.ReportByProducttype("");

            Assert.AreEqual(AllStocks.Count, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportByProducttypeNoneFound()
        {
            
            clsStockCollection FilteredStocks = new clsStockCollection();

            FilteredStocks.ReportByProducttype("xxxxx");

            Assert.AreEqual(0, FilteredStocks.Count);
        }

        [TestMethod]

        public void ReportByProducttypeTestDataFound()
        {
            clsStockCollection FilterStocks = new clsStockCollection();

            Boolean OK = true;

            FilterStocks.ReportByProducttype("slipper");

            if (FilterStocks.Count == 2)
            {

                if (FilterStocks.StockList[0].StockId != 46)
                {
                    OK = false;
                }
                if (FilterStocks.StockList[1].StockId != 47)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            
            Assert.IsTrue(OK);
        }
        

        




    }
}
