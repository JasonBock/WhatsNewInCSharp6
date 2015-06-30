namespace WhatsNewInCSharp6.Features.Miscellaneous
{
	public sealed class UsingOldThings
	{
		private Things things;

		public UsingOldThings()
		{
			// I can do this:
			//this.things = new Things(_ => { Console.Out.WriteLine(_); });
			//this.things = new Things(_ => { Console.Out.WriteLine(_); return string.Empty; });

			// But in C#5, I can't do this - I get an ambiguous call error:
			//this.things = new Things(this.ActionCallback);
			//this.things = new Things(this.FuncCallback);

			// The only way to fix it in C#5 is to add casts:
			//this.things = new Things((Action<string>)this.ActionCallback);
			//this.things = new Things((Func<string, string>)this.FuncCallback);

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
