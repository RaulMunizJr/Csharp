using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHashSet
{
	class Program
	{
		static void Main(string[] args)
		{
			var myHash = new HashSet<string>(); //removes duplicates!

			myHash.Add("hello");
			myHash.Add("hello");

			string[] s = new string[] { "hello" };

			Console.WriteLine(myHash.Count);

			//A quick way to make comparison if value is contained in the other structure
			Console.WriteLine(myHash.Overlaps(s));

			//Console.ReadLine();
		}
	}
}
