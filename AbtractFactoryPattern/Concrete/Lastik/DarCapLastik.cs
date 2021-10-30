using AbtractFactoryPattern.Interface;
using System;
namespace AbtractFactoryPattern.Concrete.Lastik
{
	public class DarCapLastik : ILastik
	{
		public void LastikUret()
		{
			Console.WriteLine("Dar çaplı lastik üretildi!");
		}
	}
}