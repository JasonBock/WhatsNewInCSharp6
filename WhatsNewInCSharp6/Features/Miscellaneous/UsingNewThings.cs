namespace WhatsNewInCSharp6.Features.Miscellaneous
{
	public sealed class UsingNewThings
	{
		private Things things;

		public UsingNewThings()
		{
			// Now methods that return values can just be passed in directly:
			//this.things = new Things((Action<string>)this.ActionCallback);
			//this.things = new Things(this.FuncCallback);
			this.things = new Things
			{
				[0] = "Tesla",
				[1] = "eBook",
				[2] = "MP3"
			};
		}

		public override string ToString()
		{
#pragma warning disable CS0219
			var x = 0;
#pragma warning restore CS0219

			return string.Join(", ", this.things[0], this.things[1], this.things[2]);
		}
	}
}
