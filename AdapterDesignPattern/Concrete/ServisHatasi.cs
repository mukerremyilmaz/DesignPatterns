using AdapterDesignPattern.Interface;
using System;
namespace AdapterDesignPattern.Concrete
{
	public class ServisHatasi : IHata
	{
		private int no;
		private string aciklama;
		public int No { get { return no; } set { no = value; } }
		public string Aciklama { get { return aciklama; } set { aciklama = value; } }
		public void EPostaYolla()
		{
			Console.WriteLine("{0}\t{1} -> Servis hatası eposta ile gönderildi", no.ToString(), aciklama);
		}
	}
}