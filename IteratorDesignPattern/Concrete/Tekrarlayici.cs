namespace IteratorDesignPattern.Concrete
{
	public class Tekrarlayici : Abstract.Tekrarlayici
	{
		Kume kume;
		int mevcut = 0;
		public Tekrarlayici(Kume kume)
		{
			this.kume = kume;
		}
		public override object IlkNesne()
		{
			return kume[0];
		}
		public override object SonrakiNesne()
		{
			object ret = null;
			if (mevcut < kume.Sayac - 1)
			{
				ret = kume[++mevcut];
			}
			return ret;
		}
		public override object MevcutNesne()
		{
			return kume[mevcut];
		}
		public override bool YapildiMi()
		{
			return mevcut >= kume.Sayac;
		}
	}
}