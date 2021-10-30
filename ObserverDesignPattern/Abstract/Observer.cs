using ObserverDesignPattern.Concrete;
namespace ObserverDesignPattern.Abstract
{
	public abstract class Observer
	{
		protected Konu Konu;
		public abstract void Guncelle();
	}
}