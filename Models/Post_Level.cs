using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JobFind_BE.Models
{
	public class Post_Level
	{
		[Key]
		public int Id { get; set; }
		[ForeignKey("Post")]
		public int PostId { get; set; }
		[ForeignKey("Level")]
		public int levelId { get; set; }
		public DateTime Created_at { get; set; } = DateTime.Now;
		public DateTime Updated_at { get; set; } = DateTime.Now;
		//navigation properties
		public Post Post { get; set; }
		public Level Level { get; set; }
	}
}
