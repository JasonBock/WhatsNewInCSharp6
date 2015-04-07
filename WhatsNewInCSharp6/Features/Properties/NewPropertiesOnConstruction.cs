using System;

namespace WhatsNewInCSharp6.Features.Properties
{
	public sealed class NewPropertiesOnConstruction
	{
		public NewPropertiesOnConstruction()
		{
			this.ReadWriteData = this.GetGuid();
			this.ReadOnlyData = this.GetGuid();
		}

		public Guid ReadWriteData { get; set; }
		public Guid ReadOnlyData { get; }

		public Guid GetGuid() { return Guid.Empty; }
	}
}
