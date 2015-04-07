using System;
using System.IO;
using WhatsNewInCSharp6.Features.Methods.Helpers;

namespace WhatsNewInCSharp6.Features.Methods
{
	public sealed class OldMethods
	{
		private int x = new Random().Next();
		private int y = new Random().Next();

		public int CalculateMinimum()
		{
			return OldMethodHelpers.GetMinimum(x, y);
		}

		public void Print(TextWriter writer)
		{
			writer.Produce(x, y);
		}

		public void SetValues(int newX, int newY)
		{
			this.x = newX;
			this.y = newY;
		}
	}
}
