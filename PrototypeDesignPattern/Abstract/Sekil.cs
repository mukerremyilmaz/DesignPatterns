using System;
namespace PrototypeDesignPattern.Abstract
{
	public abstract class Sekil : ICloneable
	{
		public string Id { get; set; }
		public string Tip { get; set; }
		public abstract void Ciz();
		public object Clone()
		{
			return MemberwiseClone();
		}
	}
}