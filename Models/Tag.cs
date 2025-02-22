using System.ComponentModel.DataAnnotations;

namespace JobFind_BE.Models
{
	public class Tag
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; } = string.Empty;
		public DateTime CreatedAt { get; set; } = DateTime.Now;
		public DateTime UpdatedAt { get; set; } = DateTime.Now;
		public ICollection<Post_Tag> post_Tags { get; set; } = new List<Post_Tag>();
	}
}
