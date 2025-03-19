using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace JobFind_BE.Models
{
	public class Company
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; } = string.Empty;
		[Required]
		public string Logo { get; set; } = string.Empty;
		[Required]
		public string Thumbnail { get; set; } = string.Empty;
		[Required]
		public string Description { get; set; } = string.Empty;
		[Required]
		public int Amount_of_employee { get; set; }
		[Required]
		public string Tax_number { get; set; } = string.Empty;
		[Required]	
		public string Status { get; set; } = string.Empty;
		[Required]
		public string Website { get; set; } = string.Empty;

		public DateTime Created_at { get; set; } = DateTime.Now;
		public DateTime Updated_at { get; set; } = DateTime.Now;

		public ICollection<Post> Post { get; set; } = new List<Post>();
		public ICollection<User_Company> User_Companies { get; set; } = new List<User_Company>();
	}
}
