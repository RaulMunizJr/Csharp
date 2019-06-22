using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTuple //List of different types
{
	class Program
	{
		static void Main(string[] args)
		{
			//Tuple<int, string, bool> myTuple = new Tuple<int, string, bool>(1, "hello", true);

			var myTuple = Tuple.Create(1, "hello", true); //can be created either way.

			//Console.WriteLine(myTuple.Item1);
			//Console.ReadLine();
		}
	}
}
