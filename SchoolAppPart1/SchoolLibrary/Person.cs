using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
	public abstract class Person //abstract: don't instanitate Person class directly
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }

		public abstract float ComputeGradeAverage(); //in base class so must be imp in subs

		//virtual methods: write in base class w/option of overriding later

		public virtual string SendMessage(string message)
		{
			var sb = new StringBuilder();
			var timeStamp = String.Format("Sent on {0:D} at {0:t}", DateTime.Now); //D-long t-short
			sb.AppendLine(timeStamp);
			sb.AppendLine("");
			sb.AppendLine("Dear " + FirstName + ",");
			sb.AppendLine(message);
			return sb.ToString();
		}
	}
}
