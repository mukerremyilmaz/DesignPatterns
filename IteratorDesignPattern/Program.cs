using IteratorDesignPattern.Concrete;
using System;
namespace IteratorDesignPattern
{
	class Program
	{
		static void Main(string[] args)
        {
            Kume kume = new Kume();
            kume[0] = "Nesne A";
            kume[1] = "Nesne B";
            kume[2] = "Nesne C";
            kume[3] = "Nesne D";
            Tekrarlayici tekrarlayici = kume.TekrarlayiciOlustur();
            object nesne = tekrarlayici.IlkNesne();
            while (nesne != null)
            {
                Console.WriteLine(nesne);
                nesne = tekrarlayici.SonrakiNesne();
            }
            Console.ReadKey();
        }
	}
}