using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http; //for HttpClient
using System.Text;
using System.Threading; // for Thread!
using System.Threading.Tasks;

namespace LearningAsync
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Downloading File");
			Download(); //someone else is getting "hired"
			Console.ReadLine(); //continued here!
		}

		static async void Download()
		{
			//Task.Run(() => { //start task with default values
			//	Thread.Sleep(3000); //in miliseconds - 3sec											1
			//	Console.WriteLine("Download Complete");
			//});


			//await Network.Download(); //needs to be an async func to use 'await'					2
			//Console.WriteLine("Download Complete");


			//HttpClient client = new HttpClient();
			//var data = await client.GetStringAsync("http://rouxacademy.com"); //gets index file	3
			//Console.WriteLine("Download Complete" + data);


			//Network.Download(OnDownloaded); //same as below

			Network.Download((message) => Console.WriteLine("Download Complete " + message));//easier and better read

		}
		//same as above
		//static void OnDownloaded()
		//{
		//	Console.WriteLine("Download Complete");
		//}

	}

	////Imaginary external network library

	//class Network
	//{
	//	static public Task Download()
	//	{
	//		return Task.Run(() => Thread.Sleep(3000));
	//	}
	//}

	class Network
	{
		static public void Download(Action<string> callback) //Action keyword allows pass functions as delagets; ref to methods we can pass as a parameter
		{
			Task.Run(() =>
			{
				Thread.Sleep(3000);
				callback("completed");
			});
		}
	}
}
