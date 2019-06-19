using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
	public class ScienceExperiment : IScored //kind of like inheratance, are allowed to use more than 1 interface or base class seperated by ","
	{
		public string Hypothesis { get; set; }
		public string Materials { get; set; }
		public string Method { get; set; }
		public string Conclusion { get; set; }
		public float Score { get/* => throw new NotImplementedException()*/; set /*=> throw new NotImplementedException()*/; } // will only notify you
		public float MaximumScore { get/* => throw new NotImplementedException()*/; set /*=> throw new NotImplementedException()*/; } // that nothing has been done yet..
	}
}

/*
 * Interface: allows for requiring a class to implement certain properties and methods
 * kind of like a contract between all programs. if you use interface must imp a certian method signature or certain prop with a certain name
 * avoid a heirchial structure
 */
