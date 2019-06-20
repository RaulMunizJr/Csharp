using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NLog;

namespace EssentialTrainingApp
{
	class Program
	{
		public static Logger logger = LogManager.GetCurrentClassLogger(); //to add logging to app
		public static List<string> Words; //must be static because Main is a static method
		//has to be instintiated! If not it remains at null and you can't add to NULL!
		static void Main(string[] args)
		{
			logger.Trace("The program started.");
			Words = new List<string>(); //fix
			Words.Add("Bread");
			Words.Add("Milk");
			Words.Add("Cheese");

			CrazyMathProblem();
			ReadTextFile();
			Console.ReadLine();
		}

		//exception practice
		//comment out try and catch.. program crashes, shows error and exception name.. copy and paste excpetion name and uncomment out the try and catch
		private static void ReadTextFile()
		{
			try
			{
				using (var sr = new StringReader(@"C:\temp\test.txt")) //avoid \t, and other minor probs so => @
				{
					string contents = sr.ReadToEnd();
					Console.WriteLine(contents);
				}
			}
			catch (System.IO.DirectoryNotFoundException ex)
			{
				Console.WriteLine("Could not find the directory.");
				logger.Error("Directory was not found" + ex.Message);
			}
			catch (System.IO.FileNotFoundException ex)
			{
				Console.WriteLine("Couldn't find the file.");
				logger.Error(ex.Message);
			}
			catch (Exception ex) //general catch
			{
				Console.WriteLine("An unkown error occured " + ex.Message); //will display to the user for feedback purposes
			}
			finally
			{
				Console.WriteLine("The finally runs all the time!");
			}
		}
		
		//debugger practice, click on the gray zone to the left of the line you want to check.
		//then analyze using continue or next step..
		private static int CrazyMathProblem()
		{
			var income = 1000;
			for (var i = 10; i >/*=*/ 0; i--) //will eventually divde by 0
			{
				income = income = (income / i);
			}

			return income;
		}
	}
}
