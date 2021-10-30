using AbstractFactoryPattern.Concrete;
using AbtractFactoryPattern.Abstract;
using AbtractFactoryPattern.Interface;
namespace AbtractFactoryPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			AbstractFactory cam = FactoryProducer.getFactory("cam");
			ICam fcam = cam.CamUret("sunroofcam");
			fcam.CamUret();
			AbstractFactory lastik = FactoryProducer.getFactory("lastik");
			ILastik normal = lastik.LastikUret("normalcaplastik");
			normal.LastikUret();
		}
	}
}