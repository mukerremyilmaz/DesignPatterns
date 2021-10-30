namespace AdapterDesignPattern.Interface
{
	public interface IHata
	{
		int No { get; set; }
		string Aciklama { get; set; }
		void EPostaYolla();
	}
}