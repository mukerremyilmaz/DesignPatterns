using System;

namespace FacadeDesignPattern
{
	public class MerkezBanka
	{
		public bool KaralisteKontrol(string TCKimlikNo)
		{
			if (int.Parse(TCKimlikNo.Substring(0, 1)) % 2 == 0)//TC kimlik numarasının ilk rakamının çift olup olmadığına bakıyoruz.
			{
				Console.WriteLine("Merkez Bankası kayıtlarında kara listede olduğunuz görüldü.");
				return true;
			}
			else
			{
				Console.WriteLine("Merkez Bankası kayıtlarında kara listede olmadığınız görüldü.");
				return false;
			}
		}
	}
}