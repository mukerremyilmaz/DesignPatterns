using BuilderPattern.Interface;
namespace BuilderPattern.Abstract
{
	public abstract class Burger : IKalem
	{
		public abstract IAmbalaj Ambalaj();
		public abstract float FiyatVer();
		public abstract string IsimVer();
	}
}