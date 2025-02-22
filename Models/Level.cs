using System.ComponentModel.DataAnnotations;

namespace JobFind_BE.Models
{
	public class Level
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; } = string.Empty;
		public DateTime Created_at { get; set; } = DateTime.Now;
		public DateTime Updated_at { get; set; } = DateTime.Now;
		public ICollection<Post_Level> Post_Levels { get; set; } = new List<Post_Level>();
	}
}
