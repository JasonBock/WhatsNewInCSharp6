namespace WhatsNewInCSharp6.Features.Syntax
{
	public sealed class Parent
	{
		public Parent(Child child)
		{
			this.Child = child;
		}

		public Child Child { get; }
	}
}
