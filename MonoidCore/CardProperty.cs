using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MonoidCore
{
	abstract class CardProperty : CardSummonable
	{
		public abstract List<int> User { get; }

		CardSummonable _owner;
		public CardSummonable Owner { get {
				return _owner;
			} set {
				if (!User.Contains(value.ID))
				{
					throw new ArgumentException("这卡好像不能这么用。");
				}
				_owner = value;
			} }

		public abstract BigInteger Cost { get; }
		public abstract BigInteger HPMax { get; }
		public abstract BigInteger HP { get; set; }
		public abstract int Star { get; }
		public abstract int ID { get; }
		public abstract int V { get; }
		public abstract string Name { get; }
	}
}
