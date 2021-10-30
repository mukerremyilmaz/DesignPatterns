using PrototypeDesignPattern.Abstract;
using PrototypeDesignPattern.Concrete;
using System;
namespace PrototypeDesignPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			SekilBellegi.BellegiYukle();
			Sekil daire = SekilBellegi.SekilGetir("1");
			Console.WriteLine("Şekil Tipi: " + daire.Tip);
			Sekil kare = SekilBellegi.SekilGetir("2");
			Console.WriteLine("Şekil Tipi: " + kare.Tip);
			Sekil dikdortgen = SekilBellegi.SekilGetir("3");
			Console.WriteLine("Şekil Tipi: " + dikdortgen.Tip);
		}
	}
}