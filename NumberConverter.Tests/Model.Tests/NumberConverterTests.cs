using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberConverter.Models;
using System.Collections.Generic;
using System;

namespace NumberConverter.Tests
{
  [TestClass]
  public class ClassNameTests
  {
    [TestMethod]

    public void Dictionary_InitializesTranslateToNineteenCorrectly()
    {
      Dictionary<int, string> translateToNineteen = new Dictionary<int, string>(){{1, "one"}, {2, "two"}, {3, "three"}};
      Assert.AreEqual("one", translateToNineteen[1]);
      Assert.AreEqual("two", translateToNineteen[2]);
      Assert.AreEqual("three", translateToNineteen[3]);
    }
      [TestMethod]

      public void Dictionary_TranslatesToNinetyNineCorrectly()
      {
        Dictionary<int, string> translateToNinetyNine = new Dictionary<int, string>(){{20, "twenty"}, {40, "fourty"}, {99, "ninetynine"}};
        Assert.AreEqual("ninetynine", translateToNinetyNine[99]);
        Assert.AreEqual("fourty", translateToNinetyNine[40]);
        Assert.AreEqual("twenty", translateToNinetyNine[20]);
    }
  }
}