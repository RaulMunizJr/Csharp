using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
	public interface IScored
	{
		//no logic or code; define structure only
		float Score { get; set; }
		float MaximumScore { get; set; }
	}
}
