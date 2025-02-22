using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobFind_BE.Models
{
	public class Post_Position
	{
		[Key]
		public int Id { get; set; }
		[ForeignKey("Post")]
		public int PostId { get; set; }
		[ForeignKey("Position")]
		public int PositionId { get; set; }
		public DateTime Created_at { get; set; } = DateTime.Now;
		public DateTime Updated_at { get; set; } = DateTime.Now;
		//navigation properties
		public Post Post { get; set; } 
		public Position Position { get; set; }

	}
}
