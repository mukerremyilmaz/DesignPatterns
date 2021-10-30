using AbtractFactoryPattern.Interface;
using System;
namespace AbtractFactoryPattern.Concrete.Cam
{
	public class FilmliCam : ICam
	{
		public void CamUret()
		{
			Console.WriteLine("Filmli cam üretildi!");
		}
	}
}