using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {

    // public void Dispose()
    // {
    //   Pastry.ClearAll();
    // }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    // [TestMethod]
    // public void GetDescription_ReturnsDescription_String()
    // {
    //   string description = "Pierre's Pastry";
    //   Pastry newPastry = new Pastry(description);
    //   string result = newPastry.Description;
    //   Assert.AreEqual(description, result);
    // }

    // [TestMethod]
    // public void GetPrice_ReturnsPrice_Int()
    // {
    //   int price = 2;
    //   Pastry newPastry0 = new Pastry(price);
    //   int result = newPastry0.Price;
    //   Assert.AreEqual(price, result);
    // }

    // [TestMethod]
    // public void GetAll_ReturnsEmptyList_PastryList()
    // {
    //   List<Pastry> newList = new List<Pastry> { };

    //   List<Pastry> result = Pastry.GetAll();

    //   CollectionAssert.AreEqual(newList, result);
    // }

    // [TestMethod]
    // public void GetAll_ReturnsPastrys_PastryList()
    // {
    //   string description01 = "Croissant";
    //   string description02 = "Éclair";
    //   Pastry newPastry1 = new Pastry(description01);
    //   Pastry newPastry2 = new Pastry(description02);
    //   List<Pastry> newList = new List<Pastry> { newPastry1, newPastry2 };

    //   List<Pastry> result = Pastry.GetAll();

    //   CollectionAssert.AreEqual(newList, result);
    // }
  }
} 