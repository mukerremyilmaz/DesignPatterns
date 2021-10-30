using AbtractFactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtractFactoryPattern.Abstract
{
	public abstract class AbstractFactory
	{
		public abstract ICam CamUret(string cam);
		public abstract ILastik LastikUret(string lastik);
	}
}
