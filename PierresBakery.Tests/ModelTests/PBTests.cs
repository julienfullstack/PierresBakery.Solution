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
  
[TestMethod]
public void Order_ShouldUpdateBakeryOrder()
{
    // Arrange
    var bakery = new Bakery();
    int userBread = 5;
    int userPastry = 3;

    // Act
    bakery.Order(userBread, userPastry);

    // Assert
    Assert.AreEqual(userBread, Bakery.bakeryOrder["Bread"]);
    Assert.AreEqual(userPastry, Bakery.bakeryOrder["Pastry"]);
}

}
}