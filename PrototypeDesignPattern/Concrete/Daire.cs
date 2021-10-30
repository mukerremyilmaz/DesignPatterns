using PrototypeDesignPattern.Abstract;
using System;
namespace PrototypeDesignPattern.Concrete
{
	public class Daire : Sekil
	{
		public override void Ciz()
		{
			Console.WriteLine("Daire nesnesinin Ciz() methodundayız.");
		}
		public Daire()
		{
			Tip = "Daire";
		}
	}
}