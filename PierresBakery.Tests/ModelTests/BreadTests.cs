using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {

//     public void Dispose()
//     {
//       Bread.ClearAll();
//     }

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
//     [TestMethod]
//     public void GetDescription_ReturnsDescription_String()
//     {
//       string description = "Pierre's Loaf";
//       Bread newBread = new Bread(description);
//       string result = newBread.Description;
//       Assert.AreEqual(description, result);
//     }

//     [TestMethod]
//     public void GetAll_ReturnsEmptyList_ItemList()
//     {
//       List<Bread> newList = new List<Bread> { };

//       List<Bread> result = Bread.GetAll();

//       CollectionAssert.AreEqual(newList, result);
//     }

//     [TestMethod]
//     public void GetAll_ReturnsBread_BreadList()
//     {
//       string description01 = "Baguette";
//       string description02 = "Fougasse";
//       Bread newBread1 = new Bread(description01);
//       Bread newBread2 = new Bread(description02);
//       List<Bread> newList = new List<Bread> { newBread1, newBread2 };

//       List<Bread> result = Bread.GetAll();

//       CollectionAssert.AreEqual(newList, result);
//     }
  }
}