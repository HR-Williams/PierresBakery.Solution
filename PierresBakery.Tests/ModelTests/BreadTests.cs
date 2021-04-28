using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {

    public void Dispose()
    {
      Bread.ClearAll();
    }

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
      List<Bread> newList = new List<Bread> { };

      List<Bread> result = Bread.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}