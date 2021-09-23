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

    public void Dictionary_InitializesTranslationCorrectly()
    {
      Dictionary<int, string> translation = new Dictionary<int, string>(){{1, "one"}, {2, "two"}, {3, "three"}};
      Assert.AreEqual("one", translation[1]);
      Assert.AreEqual("two", translation[2]);
      Assert.AreEqual("three", translation[3]);
    }
  }
}