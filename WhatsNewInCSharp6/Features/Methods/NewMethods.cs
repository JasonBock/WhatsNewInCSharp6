using System;
using System.IO;
using static WhatsNewInCSharp6.Features.Methods.Helpers.NewMethodHelpers;

namespace WhatsNewInCSharp6.Features.Methods
{
	public sealed class NewMethods
	{
		private int x = new Random().Next();
		private int y = new Random().Next();

		public int CalculateMinimum() => GetMinimum(x, y);

		public void Print(TextWriter writer) => writer.Write(x, y);

		public void SetValues(int newX, int newY)
		{
			this.x = newX;
			this.y = newY;
		}

		// Uncommenting this line of code will have the "GetMinimum" call in CalculateMinimum()
		// to resolve to this method. It will also make the "using static System.Math;" 
		// line of code unnecessary.
		// private static int GetMinimum(int x, int y) => 44;
	}
}
