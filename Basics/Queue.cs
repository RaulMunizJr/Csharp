using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningQueue //First in, First out
{
	class Program
	{
		static void Main(string[] args)
		{
			Queue<int> myQueue = new Queue<int>();

			myQueue.Enqueue(1);
			myQueue.Enqueue(2);
			myQueue.Enqueue(3);

			foreach (var item in myQueue)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine(myQueue.Dequeue()); //displays and removes first item
			Console.WriteLine(myQueue.Peek()); //displays but doesnt remove

			//Console.ReadLine();
		}
	}
}
