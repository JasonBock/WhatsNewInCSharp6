using System.IO;
using static System.Math;
// Uncommenting this line of code will cause an ambiguous call error.
//using static WhatsNewInCSharp6.Features.Methods.Helpers.MinMethod;

namespace WhatsNewInCSharp6.Features.Methods.Helpers
{
	public static class NewMethodHelpers
	{
		public static int GetMinimum(int x, int y) => Min(x, y);

		public static void Write(this TextWriter @this, int x, int y) => @this.WriteLine(string.Join(", ", x, y));
	}
}
