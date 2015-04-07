using System;
using System.IO;

namespace WhatsNewInCSharp6.Features.Methods.Helpers
{
	public static class OldMethodHelpers
	{
		public static int GetMinimum(int x, int y)
		{
			return Math.Min(x, y);
		}

		public static void Produce(this TextWriter @this, int x, int y)
		{
			@this.WriteLine(string.Join(", ", x, y));
		}
	}
}
