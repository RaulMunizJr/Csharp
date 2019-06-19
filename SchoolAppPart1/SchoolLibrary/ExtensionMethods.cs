using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
	public static class ExtensionMethods //must be static!
	{
		public static int WordCount(this string str)//must be static!
		{
			var wordCount = str.Split(new char[] { ' ', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).Length;
			return wordCount;
		}
	}
}
