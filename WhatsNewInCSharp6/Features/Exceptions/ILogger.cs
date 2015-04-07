using System.Threading.Tasks;

namespace WhatsNewInCSharp6.Features.Exceptions
{
	public interface ILogger
	{
		Task LogAsync(string messgage);
	}
}
