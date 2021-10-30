using AbtractFactoryPattern.Interface;
using System;
namespace AbtractFactoryPattern.Concrete.Lastik
{
	public class NormalCapLastik : ILastik
	{
		public void LastikUret()
		{
			Console.WriteLine("Normal çaplı lastik üretildi!");
		}
	}
}