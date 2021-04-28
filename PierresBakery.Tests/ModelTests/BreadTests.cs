using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread("test");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Pierre's Loaf";
      Bread newBread = new Bread(description);
      string result = newBread.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
public void GetAll_ReturnsEmptyList_ItemList()
{
  // Arrange
  List<Bread> newList = new List<Bread> { };

  // Act
  List<Bread> result = Bread.GetAll();

  // Assert
  CollectionAssert.AreEqual(newList, result);
}
  }
}