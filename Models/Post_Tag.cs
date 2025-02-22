using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobFind_BE.Models
{
	public class Post_Tag
	{
		[Key]
		public int Id { get; set; }
		[ForeignKey("Post")]
		public int PostId { get; set; }
		[ForeignKey("Tag")]
		public int TagId { get; set; }
		public DateTime Created_at { get; set; } = DateTime.Now;
		public DateTime Updated_at { get; set; } = DateTime.Now;

		//navigation
		public Post Post { get; set; }
		public Tag Tag { get; set; }
	}
}
