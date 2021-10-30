using BuilderPattern.Interface;
namespace BuilderPattern.Concrete.Ambalajlar
{
	public class Paket : IAmbalaj
	{
		public string AmbalajVer()
		{
			return "Paket";
		}
	}
}