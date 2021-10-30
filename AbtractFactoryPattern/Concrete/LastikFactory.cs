using AbtractFactoryPattern.Abstract;
using AbtractFactoryPattern.Concrete.Lastik;
using AbtractFactoryPattern.Interface;
namespace AbtractFactoryPattern.Concrete
{
	public class LastikFactory : AbstractFactory
	{
		public override ICam CamUret(string cam)
		{
			return null;
		}
		public override ILastik LastikUret(string lastik)
		{
			switch (lastik)
			{
				case "geniscaplastik":
					return new GenisCapLastik();
				case "darcaplastik":
					return new DarCapLastik();
				case "normalcaplastik":
					return new NormalCapLastik();
				default: return null;
			}
		}
	}
}