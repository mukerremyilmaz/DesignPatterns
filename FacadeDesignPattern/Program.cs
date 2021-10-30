using System;
namespace FacadeDesignPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Facade facade = new Facade();
			Musteri musteri1 = new Musteri() { Ad = "Hakan Yılmaz", MusteriNumarasi = 1, TCKimlikNo = "49483541496" };
			Musteri musteri2 = new Musteri() { Ad = "Hatice Yılmaz", MusteriNumarasi = 1, TCKimlikNo = "16564964196" };
			facade.KrediKullan(musteri1, 100000);
			Console.WriteLine("\n\n");
			facade.KrediKullan(musteri2, 100000);
		}
	}
}
