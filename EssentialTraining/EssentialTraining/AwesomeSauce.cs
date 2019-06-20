using System;
using System.Collections.Generic; //need for List
using System.Text;

namespace EssentialTraining
{
	public class AwesomeSauce
	{
		public List<string> Sauces { get; set; } //must be instantiated!

		public AwesomeSauce() //ctor, tab twice
		{
			Sauces = new List<string>();
		}

		public bool IsSauceAwesome(string sauce)
		{
			return Sauces.Contains(sauce);
		}
	}
}
