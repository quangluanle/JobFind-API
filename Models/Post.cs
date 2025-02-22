using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobFind_BE.Models
{
	public class Post
	{
		[Key]
        public int Id { get; set; }
		[Required]
		public string Title { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		[Required]
		public string Status { get; set; } = string.Empty;
		[ForeignKey("Company")]
		public int Company_id { get; set; }

		[ForeignKey("Area")]
		public int Area_id { get; set; }
		public DateTime Due_at { get; set; }
		public string Benefit { get; set; } = string.Empty;
		[ForeignKey("FormOfWork")]
		public int Form_of_work_id { get; set; }
		public int Amount { get; set; }
		[Column(TypeName = "decimal(18,2)")]
		public decimal Salary { get; set; }
		[ForeignKey("Category")]
		public int Category_id { get; set; }
		public DateTime Created_at { get; set; } = DateTime.Now;
		public DateTime Updated_at { get; set; } = DateTime.Now;
		public Company Companies { get; set; }
		public Area Areas { get; set; }
		public FormOfWork FormOfWorks { get; set; }
		public Category Categories { get; set; }
		public ICollection<Post_Tag> Post_Tags { get; set; } = new List<Post_Tag>();
		public ICollection<Post_Level> Post_Levels { get; set; } = new List<Post_Level>();
		public ICollection<Post_Position> post_Positions { get; set; } = new List<Post_Position>();
		public ICollection<Post_User> post_users { get; set; } = new List<Post_User>();
	}
}
