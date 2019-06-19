using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
	class School
	{
		public string Name { get; set; } //auto properties "encapsulation"
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string PhoneNumber { get; set; }

		private string _twitterAddress;
		public string TwitterAddress
		{
			//make sure the twitter address starts with @
			get { return _twitterAddress; }
			set
			{
				if (value.StartsWith("@"))
				{
					_twitterAddress = value;
				}
				else
				{
					throw new Exception("The twitter address must begin with @");
				}
			}

		}

		//SchoolLibrary.Elementary.Volume volume; //"SchoolLibrary" not necessary
		//HighSchool.Volume volume; //"SchoolLibrary" not necessary
		public School() //ctor tab twice, for constructor
		{
			Name = "Untitled School";
			PhoneNumber = "555-1234";
		}

		public School(string SchoolName, string SchoolPhoneNumber)
		{
			Name = SchoolName;
			PhoneNumber = SchoolPhoneNumber;
			//make sure to check contents
		}
		/*          Polymorphism - Operater overloading */
		//public float AverageThreeScores(float a, float b, float c)
		//{
		//    var result = (a + b + c) / 3;
		//    return result;
		//}

		//function body expression
		public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;
		//static - work directly, no instance
		public static int AverageThreeScores(int a, int b, int c)
		{
			//var temp = 15;
			//temp.ToString();

			var result = (a + b + c) / 3;
			return result;
		}
		//must use override for prediction
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine(this.Name); //type this to see your vars, also "this" is not necessary
			sb.AppendLine(this.Address);
			sb.AppendLine(this.City);
			sb.Append(", ");
			sb.Append(this.State);
			sb.Append("  ");
			sb.Append(this.Zip);

			return sb.ToString();
		}
	}
}
