using MonoidCore.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoidCore.Cards
{
	class Lemon : CardMove
	{
		public override int ID
		{
			get
			{
				return 1;
			}
		}

		public override string Name
		{
			get
			{
				return Resources.Name_Lemon;
			}
		}

		public override int Star
		{
			get
			{
				return 5;
			}
		}

		public override int V
		{
			get
			{
				return 0;
			}
		}
	}
	class Lime : CardMove
	{
		public override int ID
		{
			get
			{
				return 1;
			}
		}

		public override string Name
		{
			get
			{
				return Resources.Name_Lime;
			}
		}

		public override int Star
		{
			get
			{
				return 5;
			}
		}

		public override int V
		{
			get
			{
				return 1;
			}
		}
	}
}
