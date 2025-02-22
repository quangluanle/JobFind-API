using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JobFind_BE.DTOs.Post
{
	public class PostDto
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Title { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		[Required]
		public string Status { get; set; } = string.Empty;
		// Foreign key to Company
		[ForeignKey("Company")]

		public int Company_id { get; set; }
		// Foreign key to Area
		[ForeignKey("Area")]
		public int Area_id { get; set; }
		public DateTime Due_at { get; set; }

		public string Benefit { get; set; } = string.Empty;

		// Foreign key to FormOfWork
		[ForeignKey("FormOfWork")]
		public int Form_of_work_id { get; set; }
		public int Amount { get; set; }
		[Column(TypeName = "decimal(18,2)")]
		public decimal Salary { get; set; }

		// Foreign key to Category
		[ForeignKey("Category")]
		public int Category_id { get; set; }
		public DateTime Created_at { get; set; } = DateTime.Now;
		public DateTime Updated_at { get; set; } = DateTime.Now;
	}
}
