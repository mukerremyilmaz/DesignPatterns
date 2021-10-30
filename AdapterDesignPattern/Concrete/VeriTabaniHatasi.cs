using AdapterDesignPattern.Interface;
using System;
namespace AdapterDesignPattern.Concrete
{
	public class VeriTabaniHatasi : IHata
	{
		private int no;
		private string aciklama;
		public int No { get { return no; } set { no = value; } }
		public string Aciklama { get { return aciklama; } set { aciklama = value; } }
		public void EPostaYolla()
		{
			Console.WriteLine("{0}\t{1} -> Veritabanı hatası eposta ile gönderildi", no.ToString(), aciklama);
		}
	}
}