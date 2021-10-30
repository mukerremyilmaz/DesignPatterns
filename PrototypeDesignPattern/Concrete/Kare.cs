using PrototypeDesignPattern.Abstract;
using System;
namespace PrototypeDesignPattern.Concrete
{
	public class Kare : Sekil
	{
		public override void Ciz()
		{
			Console.WriteLine("Kare nesnesinin Ciz() methodundayız.");
		}
		public Kare()
		{
			Tip = "Kare";
		}
	}
}