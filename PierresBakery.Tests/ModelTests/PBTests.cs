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
    }
}
