using System;
namespace SingletonDesignPattern
{
	public class Ayarlar
	{
		private Ayarlar()
		{
			Console.WriteLine("Ayarlar oluşturuldu, hafızaya alındı.");
		}
		public static Ayarlar AyarlariGetir()
		{
			if (ayarlar == null)
			{
				lock (hafizadaKilitliNesneOrnegi) //multithread uygulamalar için bir kilitleme mekanizması kuruluyor.
				{
					if (ayarlar==null)
					{
						ayarlar = new Ayarlar();
						Console.WriteLine("Ayarlar oluşturuluyor...");
						Console.WriteLine("Ayarlar yükleniyor...");
						ekranDondurme = false;
						hucreselVeri = true;
						kablosuz = false;
						bluetooth = true;
						ucakModu = false;
					}
				}
			}
			else
			{
				Console.WriteLine("Ayarlar oluşturulmadı, hafızaya alınmış olan ayarlar alındı.");
			}
			return ayarlar;
		}
		private static Ayarlar ayarlar = null;
		private static object hafizadaKilitliNesneOrnegi = new object();
		private static bool ucakModu;
		private static bool bluetooth;
		private static bool kablosuz;
		private static bool hucreselVeri;
		private static bool ekranDondurme;
		public bool UcakModu
		{
			get
			{
				return ucakModu;
			}
		}
		public bool EkranDondurme
		{
			get
			{
				return ekranDondurme;
			}
		}
		public bool Bluetooth
		{
			get
			{
				return bluetooth;
			}
		}
		public bool Kablosuz
		{
			get
			{
				return kablosuz;
			}
		}
		public bool HucreselVeri
		{
			get
			{
				return hucreselVeri;
			}
		}
	}
}