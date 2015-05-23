using System;
using System.Globalization;

namespace WhatsNewInCSharp6.Extensions
{
	internal static class FormattableStringExtensions
	{
		internal static string Using(FormattableString @this, CultureInfo culture)
		{
			return @this.ToString(culture);
		}

		// Note: This doesn't work.
		internal static string UsingEx(this FormattableString @this, CultureInfo culture)
		{
			return @this.ToString(culture);
		}
	}
}
