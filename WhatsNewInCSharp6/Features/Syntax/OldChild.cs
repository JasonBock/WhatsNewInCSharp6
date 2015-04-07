using System;

namespace WhatsNewInCSharp6.Features.Syntax
{
	public sealed class OldChild
		: Child
	{
		public OldChild(string firstName, string lastName, DateTime birth)
			: base(firstName, lastName, birth)
		{ }

		public override string ToString()
		{
			base.ToString();
			return string.Format("{0} {1} - {2:MMMM dd, yyyy}", 
				this.FirstName, this.LastName, this.Birth);
			// Alternatively:
			// return this.FirstName + " " + this.LastName + " - " + this.Birth.ToString("MMMM dd, yyyy");
      }
	}
}
