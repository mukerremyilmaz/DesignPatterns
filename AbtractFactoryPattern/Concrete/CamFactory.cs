using AbtractFactoryPattern.Abstract;
using AbtractFactoryPattern.Concrete.Cam;
using AbtractFactoryPattern.Interface;
using System;
namespace AbtractFactoryPattern.Concrete
{
	public class CamFactory : AbstractFactory
	{
		public override ICam CamUret(string cam)
		{
			switch (cam)
			{
				case "kursungecirmezcam":
					return new KursunGecirmezCam();
				case "filmlicam":
					return new FilmliCam();
				case "sunroofcam":
					return new SunroofCam();
				default: return null;
			}
		}
		public override ILastik LastikUret(string lastik)
		{
			return null;
		}
	}
}