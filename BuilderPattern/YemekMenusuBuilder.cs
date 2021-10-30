using BuilderPattern.Concrete;
using BuilderPattern.Concrete.Icecekler;
using BuilderPattern.Concrete.Yiyecekler;
namespace BuilderPattern
{
	public class YemekMenusuBuilder
	{
		public YemekMenusu StandartYemekMenusuHazirla()
		{
			YemekMenusu yemek = new YemekMenusu();
			yemek.KalemEkle(new TavukBurger());
			yemek.KalemEkle(new CocaCola());
			return yemek;
		}
		public YemekMenusu VejeteryanYemekMenusuHazirla()
		{
			YemekMenusu yemek = new YemekMenusu();
			yemek.KalemEkle(new VejeteryanBurger());
			yemek.KalemEkle(new Pepsi());
			return yemek;
		}
	}
}