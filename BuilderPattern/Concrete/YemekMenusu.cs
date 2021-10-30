using BuilderPattern.Interface;
using System;
using System.Collections.Generic;
namespace BuilderPattern.Concrete
{
	public class YemekMenusu
	{
		List<IKalem> kalemListesi = new List<IKalem>();
		public void KalemEkle(IKalem kalem)
		{
			kalemListesi.Add(kalem);
		}
		public float TutarHesapla()
		{
			float tutar = 0;
			foreach (IKalem kalem in kalemListesi)
			{
				tutar += kalem.FiyatVer();
			}
			return tutar;
		}
		public void KalemleriGoster()
		{
			foreach (IKalem kalem in kalemListesi)
			{
				Console.WriteLine("Kalem\t\t: " + kalem.IsimVer());
				Console.WriteLine("Paketleme\t: " + kalem.Ambalaj().AmbalajVer());
				Console.WriteLine("Fiyat\t\t: " + kalem.FiyatVer());
				Console.WriteLine("---------------------------");
			}
		}
	}
}