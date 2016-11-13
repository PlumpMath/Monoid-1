using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoidCore
{
	interface Card
	{
		int Star { get; }
		int ID { get; }
		int V { get; }
		string Name { get; }
	}
}
