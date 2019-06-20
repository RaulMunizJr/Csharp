using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
	public class SimpleArray //make sure to make it public or wont be seen by unit test!
	{
		public string[] GroceryList; //must be initialized first!!

		public SimpleArray() //ctor -> tab twice 
		{
			GroceryList = new string[4] { "Bread", "Milk", "Eggs", "Cheese" };
		}

		public override string ToString()//must override toString method to avoid C# assumption vals
		{
			return "There are " + GroceryList.Length + " and they are: " + GroceryList.ToString(); //better to loop
		}

	}
}
