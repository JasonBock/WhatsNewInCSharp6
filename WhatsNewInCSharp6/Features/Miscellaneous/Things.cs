using System.Collections.Generic;

namespace WhatsNewInCSharp6.Features.Miscellaneous
{
	public sealed class Things
	{
		private Dictionary<int, string> things = new Dictionary<int, string>();

		public Things() : base() { }

		public string this[int i]
		{
			get
			{
				return this.things[i];
			}
			set
			{
				this.things[i] = value;
			}
		}
	}
}
