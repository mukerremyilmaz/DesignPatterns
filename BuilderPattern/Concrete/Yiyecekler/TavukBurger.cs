using BuilderPattern.Abstract;
using BuilderPattern.Concrete.Ambalajlar;
using BuilderPattern.Interface;
namespace BuilderPattern.Concrete.Yiyecekler
{
	public class TavukBurger : Burger
	{
		public override float FiyatVer()
		{
			return 15.99f;
		}
		public override string IsimVer()
		{
			return "Tavuk Burger";
		}
		public override IAmbalaj Ambalaj()
		{
			return new Paket();
		}
	}
}