using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobFind_BE.Models
{
	public class User_Company
	{
		[Key]
		public int Id { get; set; }
		[ForeignKey("AppUser")]
		public int UserId { get; set; }
		[ForeignKey("Company")]
		public int CompanyId { get; set; }
		public DateTime Created_at { get; set; } = DateTime.Now;
		public DateTime Updated_at { get; set; } = DateTime.Now;
		//navigation properties
		public AppUser? Users { get; set; }
		public Company? Companies { get; set; }
	}
}
