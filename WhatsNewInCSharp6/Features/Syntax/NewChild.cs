using System;

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
		}
	}
}
