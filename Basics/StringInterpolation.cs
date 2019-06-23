using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningStringInterpolation
{
	class Program
	{
		static void Main(string[] args)
		{
			/* OK, but has memory and performance issues!
			 * var world = "world";
			 * var s = "hello " + world;
			 */

			/* Better! => String Interpolation
			 * var s2 = $"hello {world}";
			 */

			var point = new { x = 1, y = 2 };

			Console.WriteLine("x " + point.x + " y " + point.y); //string concanination -> a lot of work for the 'garbage collector'

			Console.WriteLine("x {0} y {1}", point.x, point.y); //string formatting

			Console.WriteLine($"x {point.x} y {point.y}"); //string interpolation -> better memory performance!


			/*************************** limiting decimals! ********************************************/
			var points = new { x = 1.1234, y = 2.1254 };
			Console.WriteLine($"x {points.x} y {points.y,10:N1}"); //,10 added 10 spaces withing the string while N1 only got on decimal place
			//Console.ReadLine();
		}
	}
}
