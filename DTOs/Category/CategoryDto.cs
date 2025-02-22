using System.ComponentModel.DataAnnotations;

namespace JobFind_BE.DTOs.Category
{
	public class CategoryDto
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public DateTime Created_at { get; set; } = DateTime.Now;
		public DateTime Updated_at { get; set; } = DateTime.Now;
	}
}
