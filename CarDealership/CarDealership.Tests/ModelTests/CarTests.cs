using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using cardealership;
namespace cardealership.Tests
{
    [TestClass]
    public class CarTests
    {
      [TestMethod]
      public void GetId_CarsInstantiateWithAnIdAndGetterReturns_Int()
      {
        //Arrange
        string description = "1993 Ford Escape";
        Car newItem = new Car(description, 1, 2);

        //Act
        int result = newItem.getId();

        //Assert
        Assert.AreEqual(1, result);
      }

      [TestMethod]
  public void Find_ReturnsCorrectItem_Item()
  {
    //Arrange
    string description01 = "1993 Ford Escape";
    string description02 = "2002 Toyota Camry";
    Car newItem1 = new Car(description01, 200, 140000);
    Car newItem2 = new Car(description02, 5000, 150);

    //Act
    int id = newItem2.getId();
    Car result = Car.Find(id);

    //Assert
    Assert.AreEqual(description02, result.getModel());
  }

    }
}
