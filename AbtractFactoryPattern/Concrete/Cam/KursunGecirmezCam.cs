using AbtractFactoryPattern.Interface;
using System;
namespace AbtractFactoryPattern.Concrete.Cam
{
	public class KursunGecirmezCam : ICam
	{
		public void CamUret()
		{
			Console.WriteLine("Kurşun geçirmez cam üretildi!");
		}
	}
}