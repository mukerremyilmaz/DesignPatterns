using AbtractFactoryPattern.Abstract;
using AbtractFactoryPattern.Concrete;
namespace AbstractFactoryPattern.Concrete
{
	public class FactoryProducer
	{
		public static AbstractFactory getFactory(string factory)
		{
			switch (factory)
			{
				case "cam":
					return new CamFactory();
				case "lastik":
					return new LastikFactory();
				default:
					return null;
			}
		}
	}
}