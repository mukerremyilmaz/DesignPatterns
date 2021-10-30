using System;
namespace FacadeDesignPattern
{
	class Banka
	{
		public bool KrediyiKullan(Musteri musteri, decimal talepEdilenMiktar)
		{
			if (new Random().Next() % 2 == 0) //Rastgele sayı üretip, üretilen sayının çift olup olmadığına bakıyoruz.
			{
				Console.WriteLine("Talep ettiğiniz miktarda krediyi kullanabileceğiniz görüldü.");
				return true;
			}
			else
			{
				Console.WriteLine("Talep ettiğiniz miktarda krediyi kullanamayacağınız görüldü.");
				return false;
			}
		}
	}
}