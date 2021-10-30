using AdapterDesignPattern.Concrete;
using AdapterDesignPattern.Interface;
using System.Collections.Generic;
namespace AdapterDesignPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			SMSMesaj smsMesaj = new SMSMesaj() { HataNo = 4000, HataAciklamasi = "Şebekeye erişilemiyor." };
			List<IHata> hatalar = new List<IHata>();
			hatalar.Add(new VeriTabaniHatasi() { No = 1000, Aciklama = "Bağlantı sağlanamadı." });
			hatalar.Add(new VeriTabaniHatasi() { No = 1001, Aciklama = "Sorgu hatası." });
			hatalar.Add(new ServisHatasi() { No = 2000, Aciklama = "Yetki yok." });
			hatalar.Add(new ServisHatasi() { No = 2001, Aciklama = "Servise erişilemedi." });
			hatalar.Add(new SMSMesajAdapter(smsMesaj));
			foreach (var hata in hatalar)
			{
				hata.EPostaYolla();
			}
		}
	}
}
