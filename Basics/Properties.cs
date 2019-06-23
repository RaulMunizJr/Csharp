using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProperties
{
	class Player
	{
		//public bool isAlive = true;
		public bool IsAlive
		{
			get { return Health > 0; } //true only
		}

		public int Health { get; private set; } = 100; //prop + double tab
		//private so it can only we changed within class

		public void Hit()
		{
			Random r = new Random();
			Health -= r.Next(5, 50);
		}

		//public void CheckDeath() //no longer needed cause of new bool
		//{
		//	if (health <= 0)
		//		isAlive = false;
		//}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Player player = new Player();
			for (int i = 0; i < 20; i++)
			{
				player.Hit();
				//player.CheckDeath();
				Console.WriteLine("Is player alive: " + player.IsAlive);
			}
		}
	}
}
