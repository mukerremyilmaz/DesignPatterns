using BuilderPattern;
using BuilderPattern.Concrete;
using System;
namespace DesignPatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			YemekMenusuBuilder yemekMenusuBuilder = new YemekMenusuBuilder();
			Console.WriteLine("-------- Vejeteryan Yemek Menüsü --------");
			YemekMenusu vejeteryanYemekMenusu = yemekMenusuBuilder.VejeteryanYemekMenusuHazirla();
			vejeteryanYemekMenusu.KalemleriGoster();
			Console.WriteLine("Toplam Tutar\t: " + vejeteryanYemekMenusu.TutarHesapla());
			Console.WriteLine("\n\n");
			Console.WriteLine("--------  Standart Yemek Menüsü  --------");
			YemekMenusu standartYemekMenusu = yemekMenusuBuilder.StandartYemekMenusuHazirla();
			standartYemekMenusu.KalemleriGoster();
			Console.WriteLine("Toplam Tutar\t: " + standartYemekMenusu.TutarHesapla());
		}
	}
}