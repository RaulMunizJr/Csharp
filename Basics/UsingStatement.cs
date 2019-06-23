using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningUsingStatement
{
	class MyResource : IDisposable
	{
		public void Dispose()
		{
			Console.WriteLine("Disposing our resource"); //2nd
		}
	}


	class Program
	{
		static void Main(string[] args)
		{
			/*
			 * using (var client = new HttpClient())
			 * {
			 *	//download something with the client
			 * }
			 */
			using (var resource = new MyResource()) //using comes in handy when you need to dipsose afterward
			{
				Console.WriteLine("Using my resrouce"); //1st
			}
			Console.WriteLine("Finished"); //3rd

		

		}
	}
}
