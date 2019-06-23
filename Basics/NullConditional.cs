using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningNullConditional
{
	class Person
	{
		public string Name { get; set; }
	}
	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person(); //{ Name = "Tim" }; //what if this was null ->crash (null Exception)
			//Person person = null;
			//if (person != null)
			//	Console.WriteLine(person.Name);

			Console.WriteLine(person?.Name ?? "not set"); //same as above
			//in case of no initizialation, -> Name?.
		}
	}
}
