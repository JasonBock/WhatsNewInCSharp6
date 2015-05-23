using System;
using System.Globalization;
using WhatsNewInCSharp6.Extensions;

namespace WhatsNewInCSharp6.Features.Syntax
{
	public sealed class NewChild
		: Child
	{
		public NewChild(string firstName, string lastName, DateTime birth)
			: base(firstName, lastName, birth)
		{ }

		public override string ToString()
		{
			base.ToString();
			return $"{this.FirstName} {this.LastName} - {this.Birth:MMMM dd, yyyy}";

			// Formatted for a different culture (Spanish - Mexico)
			//return FormattableStringExtensions.Using(
			//	$"{this.FirstName} {this.LastName} - {this.Birth:MMMM dd, yyyy}", CultureInfo.GetCultureInfo("es-MX"));

			// This doesn't work.
			// return $"{this.FirstName} {this.LastName} - {this.Birth:MMMM dd, yyyy}".UsingEx(CultureInfo.GetCultureInfo("th-TH"));
		}
	}
}
