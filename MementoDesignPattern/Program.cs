using System;
namespace MementoDesignPattern
{
	class Program
	{
		static void Main(string[] args)
		{
            Oyun oyun = new Oyun();
            oyun.Level = 1;
            oyun.BolumAdi = "Mağara";
            Console.WriteLine(oyun.ToString());
            OyunHafiza oyunHafiza = new OyunHafiza();
            oyunHafiza.OyunKayit = oyun.Kaydet();
            oyun.Level = 2;
            oyun.BolumAdi = "Karayip Adaları";
            Console.WriteLine(oyun.ToString());
            oyun.OncekiniYukle(oyunHafiza.OyunKayit);
            Console.WriteLine(oyun.ToString());
            Console.Read();
        }
	}
}