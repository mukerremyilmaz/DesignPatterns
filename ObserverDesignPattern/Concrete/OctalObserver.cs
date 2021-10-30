using ObserverDesignPattern.Abstract;
using System;
namespace ObserverDesignPattern.Concrete
{
	public class OctalObserver : Observer
	{
		Konu konu;
		public OctalObserver(Konu konu)
		{
			this.konu = konu;
			this.konu.Bagla(this);
		}
		public override void Guncelle()
		{
			Console.WriteLine("Octal Metin: " + Convert.ToInt32(konu.DurumGetir().ToString(), 8));
		}
	}
}