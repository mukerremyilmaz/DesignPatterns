using AbtractFactoryPattern.Interface;
using System;
namespace AbtractFactoryPattern.Concrete.Lastik
{
	public class GenisCapLastik : ILastik
	{
		public void LastikUret()
		{
			Console.WriteLine("Geniş çap lastik üretildi!");
		}
	}
}