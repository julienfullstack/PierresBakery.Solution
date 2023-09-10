using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
   [TestMethod]
    public void CreateInstancesOfBakery_Bakery_Bakery()
    {
      Bakery newBakery = new Bakery();
      Assert.AreEqual(typeof(Bakery), newBakery.GetType());
    }
  }
}