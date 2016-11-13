using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoidCore
{
	abstract class CardMove : Card
	{
		public abstract int ID { get; }
		public abstract string Name { get; }
		public abstract int Star { get; }
		public abstract int V { get; }
	}
}
