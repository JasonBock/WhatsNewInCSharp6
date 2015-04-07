using System;

namespace WhatsNewInCSharp6.Features.Properties
{
	public sealed class NewProperties
	{
		public Guid ReadWriteData { get; set; } = Guid.NewGuid();
		// This would be illegal, as initializers are run before the constructor.
		// See https://msdn.microsoft.com/en-us/library/aa645759(v=vs.71).aspx
		// public Guid ReadWriteData { get; set; } = this.GetGuid();
		public Guid ReadOnlyData { get; } = Guid.NewGuid();
	}
}

// What's really generated:
/*
[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
private Guid <ReadWriteData>k__BackingField = Guid.NewGuid();
[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
private readonly Guid <ReadOnlyData>k__BackingField = Guid.NewGuid();
*/
