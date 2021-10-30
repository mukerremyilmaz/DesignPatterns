using System;
namespace SingletonDesignPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Ayarlar ayarlar = Ayarlar.AyarlariGetir();
			if (ayarlar.Bluetooth) Console.WriteLine("Bluetooth\t: Açık"); else Console.WriteLine("Bluetooth\t: Kapalı");
			if (ayarlar.Kablosuz) Console.WriteLine("Kablosuz\t: Açık"); else Console.WriteLine("Kablosuz\t: Kapalı");
			if (ayarlar.HucreselVeri) Console.WriteLine("Hücresel Veri\t: Açık"); else Console.WriteLine("Hücresel Veri\t: Kapalı");
			if (ayarlar.UcakModu) Console.WriteLine("Uçak Modu\t: Açık"); else Console.WriteLine("Uçak Modu\t: Kapalı");
			if (ayarlar.EkranDondurme) Console.WriteLine("Ekran Döndürme\t: Açık"); else Console.WriteLine("Ekran Döndürme\t: Kapalı");
			//Nesnenin tekrar üretilmediğinin testi
			Ayarlar yeniAyarlar = Ayarlar.AyarlariGetir();
		}
	}
}