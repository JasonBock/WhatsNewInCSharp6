using System;

namespace WhatsNewInCSharp6.Features.Properties
{
	public sealed class OldProperties
	{
		public OldProperties()
		{
			this.ReadWriteData = Guid.NewGuid();
			this.ReadOnlyData = Guid.NewGuid();
		}

		public Guid ReadWriteData { get; set; }
		public Guid ReadOnlyData { get; private set; }
	}
}
