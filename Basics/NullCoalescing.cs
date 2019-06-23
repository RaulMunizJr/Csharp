using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningNulls //null coalescing
{
	class Program
	{
		static void Main(string[] args)
		{
			//string s = "hello";
			string s = null;
			var s2 = s ?? "default"; //empty or not available

			//int t = 1;		the proper way for int
			int? t = null;
			var t2 = t ?? 2; //empty or not available

			Console.WriteLine(s2);
			Console.WriteLine(t2);
		}
	}
}
