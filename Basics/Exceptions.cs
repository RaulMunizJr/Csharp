using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningExceptions
{
	class Program
	{
		/*
		class Person //right click -> snippet ->propfull
		{
			private string name;

			public string Name
			{
				get { return name; }
				set
				{
					try
					{
						if (value == null)
							throw new NullReferenceException("name must have a value"); //which comes first????
						name = value;
					}
					catch(Exception)
					{
						Console.WriteLine("Name can not be null"); //THE CATCH NEAR THE EXCEPTION FLOW!
					}
				}
			}

		}
		*/
		static void Main(string[] args)
		{
			/*
			try
			{
				//throw new Exception("custom message"); //our custom exception

				//string s = null;
				//var l = s.Length;

				var person = new Person();
				person.Name = null;
			}
			catch (EncoderFallbackException ex)
			{
				Console.WriteLine(ex);
			}
			catch (NullReferenceException ex)
			{
				Console.WriteLine(ex);
			}*/

			/*********************************************************************************/

			Console.WriteLine("connected to database");

			try
			{
				throw new Exception("error while accessing database resource");
			}
			catch (Exception)
			{
				Console.WriteLine("exception caught");
			}
			finally //will always be executed
			{
				Console.WriteLine("disconnecting database");
			}
		}
	}
}
