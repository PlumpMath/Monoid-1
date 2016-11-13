using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MonoidCore
{
	interface CardSummonable : Card
	{
		BigInteger HPMax { get; }
		BigInteger HP { get; set; }
	}
}
