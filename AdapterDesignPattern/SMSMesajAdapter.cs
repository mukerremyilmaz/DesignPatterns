using AdapterDesignPattern.Concrete;
using AdapterDesignPattern.Interface;
using System;
namespace AdapterDesignPattern
{
	public class SMSMesajAdapter : IHata
	{
		public SMSMesajAdapter(SMSMesaj SMSMesaj)
		{
			smsMesaj = SMSMesaj;
		}
		private SMSMesaj smsMesaj;
		private int no;
		private string aciklama;
		public int No { get { return smsMesaj.HataNo; } set { smsMesaj.HataNo = value; } }
		public string Aciklama { get { return smsMesaj.HataAciklamasi; } set { smsMesaj.HataAciklamasi = value; } }
		public void EPostaYolla()
		{
			Console.WriteLine("{0}\t{1} -> SMS mesaj gönderim hatası eposta ile gönderildi", No, Aciklama);
		}
	}
}