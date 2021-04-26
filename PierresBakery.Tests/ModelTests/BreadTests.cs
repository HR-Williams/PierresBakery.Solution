using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
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
  }
}