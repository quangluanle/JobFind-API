using System.ComponentModel.DataAnnotations;

namespace JobFind_BE.DTOs.Account
{
	public class RegisterDto
	{
		//[Required]
		//[MinLength(3,ErrorMessage = "Tên người dùng không hợp lệ !!!")]
		//public string? Username { get; set; }
		[Required]
		[EmailAddress (ErrorMessage ="Emaill không hợp lệ !!!")]
		public string? Email { get; set; } 
		[Required]
		public string? Password { get; set; }
		[Required]
		[StringLength(10,ErrorMessage = "Số điện thoại không hợp lệ !!")]
		[RegularExpression(@"^\d{10}$", ErrorMessage = "Số điện thoại không hợp lệ !!")]
		public string? PhoneNumber { get; set; } 
	}
}
