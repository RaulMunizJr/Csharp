using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningStack //Last in, First out
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack<string> pancakes = new Stack<string>();

			pancakes.Push("First pancake");
			pancakes.Push("Second pancake");
			pancakes.Push("Third pancake");

			foreach (var pancake in pancakes) //similar to python
			{
				Console.WriteLine(pancake);
			}

			//Console.WriteLine(pancakes.Pop()); // pop removes last item
			Console.WriteLine(pancakes.Peek()); // peek doesn't remove

			Console.ReadLine();
		}
	}
}
