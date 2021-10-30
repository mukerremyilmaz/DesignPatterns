using BuilderPattern.Abstract;
using BuilderPattern.Concrete.Ambalajlar;
using BuilderPattern.Interface;
namespace BuilderPattern.Concrete.Icecekler
{
	public class Pepsi : SogukIcecek
	{
		public override IAmbalaj Ambalaj()
		{
			return new Sise();
		}
		public override float FiyatVer()
		{
			return 5.5f;
		}
		public override string IsimVer()
		{
			return "Pepsi";
		}
	}
}