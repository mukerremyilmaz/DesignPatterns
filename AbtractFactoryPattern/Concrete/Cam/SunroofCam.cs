using AbtractFactoryPattern.Interface;
using System;
namespace AbtractFactoryPattern.Concrete.Cam
{
	public class SunroofCam : ICam
	{
		public void CamUret()
		{
			Console.WriteLine("Sunroof cam üretildi!");
		}
	}
}