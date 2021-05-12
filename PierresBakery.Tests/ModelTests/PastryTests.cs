using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      int pastryPrice = 2;
      Pastry newPastry = new Pastry(pastryPrice);
      int result = newPastry.PastryPrice;
      Assert.AreEqual(pastryPrice, result);
    }

    [TestMethod]
    public void GetPastryQuantity_ReturnsPastryQuantity_Int()
    {
      int pastryQuantity = 1;
      Pastry newPastry = new Pastry(pastryQuantity);
      int result = newPastry.PastryQuantity;
      Assert.AreEqual(pastryQuantity, result);
    }

    
  }
} 