using System;

namespace FacadeDesignPattern
{
	public class Kredi
	{
		public bool KrediKullanimDurumu(Musteri musteri)
		{
			if (int.Parse(musteri.TCKimlikNo.Substring(0, 1)) % 2 == 0)//TC kimlik numarasının ilk rakamının çift olup olmadığına bakıyoruz.
			{
				Console.WriteLine("Kredi kullanım durumunuzun olumlu olduğu görüldü.");
				return true;
			}
			else
			{
				Console.WriteLine("Kredi kullanım durumunuzun olumsuz olduğu görüldü.");
				return false;
			}
		}
	}
}