using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JobFind_BE.DTOs.Area
{
	public class AreaRequestDto
	{
		[Required(ErrorMessage = "Yêu cầu nhập vùng !!!")]
		[MinLength(3, ErrorMessage = "Phải nhập ít nhất 3 kí tự !!!")]
		[MaxLength(50, ErrorMessage = "Phải nhập ít hơn 50 kí tự !!!")]
		public string Name { get; set; } = string.Empty;
	}
}
