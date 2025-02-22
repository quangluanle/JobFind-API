using JobFind_BE.Models;

namespace JobFind_BE.Interfaces
{
	public interface ITokenService
	{
		string CreateToken(AppUser user);
	}
}
