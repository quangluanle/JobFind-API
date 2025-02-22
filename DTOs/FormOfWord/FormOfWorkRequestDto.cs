using System.ComponentModel.DataAnnotations;

namespace JobFind_BE.DTOs.FormOfWork
{
	public class FormOfWorkRequestDto
	{
		[Required]
		[MinLength(5, ErrorMessage = "Vui lòng nhập thêm thông tin !!!")]
		[MaxLength(50, ErrorMessage = "Tên không được vượt quá 50 ký tự !!!")]		
		public string Name { get; set; } = string.Empty;
		[Required]
		[MinLength(5, ErrorMessage = "Vui lòng nhập thêm thông tin !!!")]
		public string Description { get; set; } = string.Empty;
	}
}
