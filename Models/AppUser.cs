
using Microsoft.AspNetCore.Identity;

namespace JobFind_BE.Models
{
	public class AppUser : IdentityUser
	{
		public string Status { get; set; } = string.Empty;
		public ICollection<Post_User> Post_User = new List<Post_User>();
		public ICollection<User_Company> User_Company = new List<User_Company>();
	}
}
