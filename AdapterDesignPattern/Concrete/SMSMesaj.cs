using AdapterDesignPattern.Interface;
using System;
namespace AdapterDesignPattern.Concrete
{
	public class SMSMesaj
	{
		public int HataNo { get; set; }
		public string HataAciklamasi { get; set; }
		public void Gonder()
		{
			Console.WriteLine("SMS mesaj gönderildi.");
		}
		public void Al()
		{
			Console.WriteLine("SMS mesaj alındı.");
		}
	}
}