using System;
namespace FacadeDesignPattern
{
	public class Facade
	{
		private Banka Banka;
		private MerkezBanka MerkezBanka;
		private Kredi Kredi;
		public Facade()
		{
			Banka = new Banka();
			MerkezBanka = new MerkezBanka();
			Kredi = new Kredi();
		}
		public void KrediKullan(Musteri musteri, decimal talepEdilenMiktar)
		{
			if (!MerkezBanka.KaralisteKontrol(musteri.TCKimlikNo) && Kredi.KrediKullanimDurumu(musteri))
			{
				if (Banka.KrediyiKullan(musteri, talepEdilenMiktar))
				{
					Console.WriteLine("Kredi kullandırıldı");
				}
				else
				{
					Console.WriteLine("Kredi kullandırılamadı.");
				}
			}
			else
			{
				Console.WriteLine("Kredi talebiniz uygun bulunmadı.");
			}
		}
	}
}