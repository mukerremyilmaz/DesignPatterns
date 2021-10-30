using ObserverDesignPattern.Abstract;
using System;
namespace ObserverDesignPattern.Concrete
{
	public class BinaryObserver : Observer
	{
		Konu konu;
		public BinaryObserver(Konu konu)
		{
			this.konu = konu;
			this.konu.Bagla(this);
		}
		public override void Guncelle()
		{
			Console.WriteLine("Binary Metin: " + Convert.ToString(konu.DurumGetir(), 2).ToUpper());
		}
	}
}