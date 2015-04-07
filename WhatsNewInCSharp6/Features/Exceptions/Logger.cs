using System;
using System.Threading.Tasks;

namespace WhatsNewInCSharp6.Features.Exceptions
{
	public sealed class Logger
		: ILogger
	{
		public async Task LogAsync(string message)
		{
			await Console.Out.WriteLineAsync(message);
		}
	}
}
