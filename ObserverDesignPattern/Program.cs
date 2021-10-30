using ObserverDesignPattern.Concrete;
using System;
namespace ObserverDesignPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Konu konu = new Konu();
			new HexaObserver(konu);
			new OctalObserver(konu);
			new BinaryObserver(konu);
			Console.WriteLine("İlk Durum Değişimi\t: 15");
			konu.DurumAyarla(15);
			Console.WriteLine("****************");
			Console.WriteLine("İkinci Durum Değişimi\t: 10");
			konu.DurumAyarla(10);
		}
	}
}