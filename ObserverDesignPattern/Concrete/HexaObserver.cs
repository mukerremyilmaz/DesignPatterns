using ObserverDesignPattern.Abstract;
using System;
using System.Text;

namespace ObserverDesignPattern.Concrete
{
	public class HexaObserver : Observer
	{
		Konu konu;
		public HexaObserver(Konu konu)
		{
			this.konu = konu;
			this.konu.Bagla(this);
		}
		public override void Guncelle()
		{
			Console.WriteLine("Hex Metin: " + Convert.ToHexString(Encoding.Default.GetBytes(konu.DurumGetir().ToString())).ToUpper());
		}
	}
}