using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
	public class Teacher : Person // inheratence from base class, Person
	{
		public string Subject { get; set; }

		public override float ComputeGradeAverage() //overrride to hide cover error
		{
			//TODO: fix imp later
			return 0.0f;
		}
	}
}
