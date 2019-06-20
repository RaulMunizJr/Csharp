using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining; //must add every time a test class is created (namepsace of whatever is being tested)

namespace EssentialTrainingTests
{
	[TestClass]
	public class SimpleArrayTest
	{
		[TestMethod]
		public void TestInstantiation()
		{
			var testInstance = new SimpleArray();
			Assert.AreEqual(testInstance.GroceryList.Length, 4);
			Assert.AreEqual(testInstance.GroceryList[1], "Milk");
		}

		[TestMethod] //add testMethod decorator otherwise it wont be recognized as a test that needs to be run
		public void TestToString()
		{
			var testInstance = new SimpleArray();
			Assert.IsTrue(testInstance.ToString().StartsWith("There are"));
		}
	}
}
