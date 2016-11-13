using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace MonoidCore
{
	abstract class CardActor : CardSummonable
	{
		public abstract BigInteger MPMax { get; }
		public abstract BigInteger MP { get; set; }
		public abstract BigInteger HPMax { get; }
		public abstract BigInteger HP { get; set; }
		public abstract int Star { get; }
		public abstract int ID { get; }
		public abstract int V { get; }
		public abstract string Name { get; }
	}
}
