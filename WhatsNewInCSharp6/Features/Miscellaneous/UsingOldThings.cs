namespace WhatsNewInCSharp6.Features.Miscellaneous
{
	public sealed class UsingOldThings
	{
		private Things things;

		public UsingOldThings()
		{
			this.things = new Things();
			this.things[0] = "Model T";
			this.things[1] = "Book";
			this.things[2] = "Album";
		}

		public override string ToString()
		{
#pragma warning disable 219
			var x = 0;
#pragma warning restore 219
			return string.Join(", ", this.things[0], this.things[1], this.things[2]);
		}
	}
}
