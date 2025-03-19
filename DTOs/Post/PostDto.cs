using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using JobFind_BE.DTOs.Area;
using JobFind_BE.DTOs.Category;
using JobFind_BE.DTOs.Company;
using JobFind_BE.DTOs.FormOfWork;

namespace JobFind_BE.DTOs.Post
{
	public class PostDto
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Status { get; set; }
		public decimal Salary { get; set; }
		public string Description { get; set; }
		public string Benefit { get; set; } = string.Empty;
		public int Amount { get; set; }
		public DateTime Due_at { get; set; }
		public CompanyDto Company { get; set; }
		public AreaDto Area { get; set; }
		public FormOfWorkDto FormOfWork { get; set; }
		public CategoryDto Category { get; set; }
		public DateTime Created_at { get; set; } = DateTime.Now;
		public DateTime Updated_at { get; set; } = DateTime.Now;
		//public List<TagDto> Tags { get; set; }
		//public List<LevelDto> Levels { get; set; }
		//public List<PositionDto> Positions { get; set; }
		//public List<UserDto> Users { get; set; }
	}
}
