using System.ComponentModel.DataAnnotations;

namespace JobFind_BE.DTOs.Area
{
	public class AreaDto
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public DateTime Created_at { get; set; } = DateTime.Now;
		public DateTime Updated_at { get; set; } = DateTime.Now;
	}
}
