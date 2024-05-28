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

            Testitem.StockId = 1040;
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


            TestStock.StockId = 1040;
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

            Testitem.StockId = 1040;
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

            Testitem.StockId = 1040;
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

            Testitem.StockId = 1040;
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




    }
}
