using PrototypeDesignPattern.Abstract;
using System;
namespace PrototypeDesignPattern.Concrete
{
	public class Dikdortgen : Sekil
	{
		public override void Ciz()
		{
			Console.WriteLine("Dikdortgen nesnesinin Ciz() methodundayız.");
		}
		public Dikdortgen()
		{
			Tip = "Dikdortgen";
		}
	}
}