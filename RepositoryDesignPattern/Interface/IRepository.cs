using System.Collections.Generic;

namespace RepositoryDesignPattern.Interface
{
	public interface IRepository<T>
	{
		List<T> Listele();
		void Ekle(T isim);
		void Sil(T isim);
		void Guncelle(T isim);
	}
}
