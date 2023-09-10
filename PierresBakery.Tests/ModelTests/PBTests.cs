using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
    [TestClass]
    public class BakeryTests
    {
        [TestMethod]
        public void BreadConstructor_CreatesInstanceOfBread_Bread()
        {
            Bread newBread = new Bread(1);
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }
        [TestMethod]
        public void PastryConstructer_CreatesInstanceOfPastry_Pastry()
        {
          Pastry newPastry = new Pastry(1);
          Assert.AreEqual(typeof(Pastry), newPastry.GetType());
        }

        [TestMethod]
        public void CalculateTotalPrice_ReturnsTotalPriceOfBread_Int()
        {
          Bread newBread = new Bread(5);
          Assert.AreEqual(20, newBread.CalculateTotalPrice());
        }

        [TestMethod]
        public void CalculateTotalPrice_ReturnsTotalPriceOfPastry_Int()
        {
          Pastry newPastry = new Pastry(7);
          Assert.AreEqual(12, newPastry.CalculateTotalPrice());
        }
        [TestMethod]
        public void CalculateTotalQuantity_ReturnsTotalQuantityOfBread_Int()
        {
          Bread newBread = new Bread(5);
          Assert.AreEqual(7, newBread.CalculateTotalQuantity());
        }

                [TestMethod]
        public void CalculateTotalQuantity_ReturnsTotalQuantityOfPastry_Int()
        {
          Pastry newPastry = new Pastry(7);
          Assert.AreEqual(9, newPastry.CalculateTotalQuantity());
        }
    }
}
