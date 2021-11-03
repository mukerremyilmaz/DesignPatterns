namespace MementoDesignPattern
{
	public class Oyun
	{
        public int Level { get; set; }
        public string BolumAdi { get; set; }
        public override string ToString()
        {
            return $"{Level}. levelın {BolumAdi} bölümündeyiz.";
        }
        public OyunKayit Kaydet()
        {
            return new OyunKayit
            {
                BolumAdi = this.BolumAdi,
                Level = this.Level
            };
        }
        public void OncekiniYukle(OyunKayit Memento)
        {
            this.BolumAdi = Memento.BolumAdi;
            this.Level = Memento.Level;
        }
    }
}