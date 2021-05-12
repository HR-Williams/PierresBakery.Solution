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
    // public void GetPrice_ReturnsPrice_Int()
    // {
    //   int price = 2;
    //   Pastry newPastry = new Pastry(price);
    //   int result = newPastry.Price;
    //   Assert.AreEqual(price, result);
    // }


    // [TestMethod]
    // public void GetAll_ReturnsPastrys_PastryList()
    // {
    //   int price01 = 2;
    //   Pastry newPastry1 = new Pastry(2);
    //   List<Pastry> newList = new List<Pastry> { newPastry1};

    //   List<Pastry> result = Pastry.GetAll();

    //   CollectionAssert.AreEqual(newList, result);
    // }
  }
} 