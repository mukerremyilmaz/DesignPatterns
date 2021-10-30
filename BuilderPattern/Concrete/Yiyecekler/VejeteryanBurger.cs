using BuilderPattern.Abstract;
using BuilderPattern.Concrete.Ambalajlar;
using BuilderPattern.Interface;
namespace BuilderPattern.Concrete.Yiyecekler
{
	public class VejeteryanBurger : Burger
	{
		public override IAmbalaj Ambalaj()
		{
			return new Paket();
		}
		public override float FiyatVer()
		{
			return 29.99f;
		}
		public override string IsimVer()
		{
			return "Vejeteryan Burger";
		}
	}
}