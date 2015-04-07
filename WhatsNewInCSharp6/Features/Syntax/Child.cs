using System;

namespace WhatsNewInCSharp6.Features.Syntax
{
	public abstract class Child
	{
		public virtual event EventHandler ToStringCalled;

		protected Child(string firstName, string lastName, DateTime birth)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Birth = birth;
		}

		public override string ToString()
		{
			this.ToStringCalled?.Invoke(this, EventArgs.Empty);
			return base.ToString();
		}

		public DateTime Birth { get; }
		public string FirstName { get; }
		public string LastName { get; }
	}
}
