using ObserverDesignPattern.Abstract;
using System.Collections.Generic;
namespace ObserverDesignPattern.Concrete
{
	public class Konu
    {
        private List<Observer> observers = new List<Observer>();
        private int durum;
        public int DurumGetir()
        {
            return durum;
        }
        public void DurumAyarla(int durum)
        {
            this.durum = durum;
            NotifyAllObservers();
        }
        public void Bagla(Observer observer)
        {
            observers.Add(observer);
        }
        public void NotifyAllObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.Guncelle();
            }
        }
    }
}