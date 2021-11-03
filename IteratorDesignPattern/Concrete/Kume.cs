using System.Collections.Generic;
namespace IteratorDesignPattern.Concrete
{
	public class Kume : Abstract.Kume
    {
        List<object> nesneler = new List<object>();
        public override Tekrarlayici TekrarlayiciOlustur()
        {
            return new Tekrarlayici(this);
        }
        public int Sayac
        {
            get { return nesneler.Count; }
        }
        public object this[int index]
        {
            get { return nesneler[index]; }
            set { nesneler.Insert(index, value); }
        }
    }
}