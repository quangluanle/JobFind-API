using System.ComponentModel.DataAnnotations;

namespace JobFind_BE.Models
{
	public class Position
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; } = string.Empty;
		[Required]
		public string Description { get; set; } = string.Empty;
		public DateTime Created_at { get; set; } = DateTime.Now;
		public DateTime Updated_at { get; set; } = DateTime.Now;
		public ICollection<Post_Position> Post_Positions { get; set; } = new List<Post_Position>();
	}
}
