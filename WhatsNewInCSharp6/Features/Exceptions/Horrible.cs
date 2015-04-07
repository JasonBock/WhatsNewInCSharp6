using System;
using System.Threading.Tasks;

namespace WhatsNewInCSharp6.Features.Exceptions
{
	public sealed class Horrible
	{
		private ILogger logger;

		public Horrible(ILogger logger)
		{
			this.logger = logger;
		}

		public async Task<int> RemainderAsync(int a, int b, bool handleOnError)
		{
			var result = 0;

			try
			{
				Math.DivRem(a, b, out result);
			}
			catch(DivideByZeroException) when (handleOnError)
			{
				await this.logger.LogAsync("Divide by zero.");
			}

         return result;
		}

		private static bool Ouch()
		{
			throw new NullReferenceException();
		}
	}
}
