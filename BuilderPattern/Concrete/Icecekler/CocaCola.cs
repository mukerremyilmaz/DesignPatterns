using BuilderPattern.Abstract;
using BuilderPattern.Concrete.Ambalajlar;
using BuilderPattern.Interface;
namespace BuilderPattern.Concrete.Icecekler
{
	public class CocaCola : SogukIcecek
	{
		public override IAmbalaj Ambalaj()
		{
			return new Sise();
		}
		public override float FiyatVer()
		{
			return 7.5f;
		}
		public override string IsimVer()
		{
			return "CocaCola";
		}
	}
}