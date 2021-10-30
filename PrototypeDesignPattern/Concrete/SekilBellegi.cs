using PrototypeDesignPattern.Abstract;
using System.Collections.Generic;
namespace PrototypeDesignPattern.Concrete
{
	public class SekilBellegi
	{
		private static Dictionary<string, Sekil> sekilEsleri = new Dictionary<string, Sekil>();

		public static Sekil SekilGetir(string id)
		{
			Sekil bellegeAlinanSekil = sekilEsleri.GetValueOrDefault(id);
			return (Sekil)bellegeAlinanSekil.Clone();
		}

		public static void BellegiYukle()
		{
			Daire daire = new Daire();
			daire.Id = "1";
			sekilEsleri.Add(daire.Id, daire);
			Kare kare = new Kare();
			kare.Id = "2";
			sekilEsleri.Add(kare.Id, kare);
			Dikdortgen dikdortgen = new Dikdortgen();
			dikdortgen.Id = "3";
			sekilEsleri.Add(dikdortgen.Id, dikdortgen);
		}
	}
}