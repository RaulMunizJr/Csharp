using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining; //to know which code where testing asiding from adding a reference

namespace EssentialTrainingTests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var testInstance = new Class1(); //obj
			var testResult = testInstance.AddTwo(9, 5); //test
			Assert.AreEqual(14, testResult, "I expect 9 + 5 to be 14");
			//Assert can be use in a variety of testing purposes.
			//Normally takes 2 inputs, but the third is an 'override' in case you want a message to print out.
			//Message will only print out if the test fails!
		}
	}
}
