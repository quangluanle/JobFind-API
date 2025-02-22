using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobFind_BE.Models
{
	public class Post_User
	{
		[Key]
		public int Id { get; set; }
		[ForeignKey("Post")]
		public int PostId { get; set; }
		[ForeignKey("AppUser")]
		public string UserId { get; set; } = string.Empty;
		public string Cv { get; set; } = string.Empty;
		public string Cover_letter { get; set; } = string.Empty;
		public string Status { get; set; } = string.Empty;
		public string Subject { get; set; } = string.Empty;
		public DateTime Created_at { get; set; } = DateTime.Now;
		public DateTime Updated_at { get; set; } = DateTime.Now;
		public AppUser AppUser { get; set; }
		public Post Post { get; set; }
	}
}
