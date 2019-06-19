using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
	public class Student : Person //inherit from base class, person
	{
		public enum GradeLevels { Freshman, Sophmore, Junior, Senior }
		public GradeLevels GradeLevel { get; set; }

		public override float ComputeGradeAverage() //overrride to hide cover error
		{
			return 4.0f;
		}

		public override string SendMessage(string message)
		{
			//return base.SendMessage(message);//calls from Person class
			var original = base.SendMEssage(message);
			var sb = new StringBuilder(original);
			sb.AppendLine("This message is private and confidential."); //appended
			return sb.ToString();
		}
	}
}
