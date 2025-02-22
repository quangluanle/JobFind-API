using JobFind_BE.DTOs.Category;
using JobFind_BE.Models;

namespace JobFind_BE.Mappers
{
	public static class CategoryMappers
	{
		public static CategoryDto toCategoryDto(this Category category)
		{
			return new CategoryDto
			{
				Id = category.Id,
				Name = category.Name,
				Created_at = category.Created_at,
				Updated_at = category.Updated_at
			};
		}
		public static Category toCategoryFromCreateAreaDto(this CategoryRequestDto categoryDto)
		{
			return new Category
			{
				Name = categoryDto.Name,
				Created_at = DateTime.Now,
				Updated_at = DateTime.Now
			};
		}
		public static Category toCategoryFromUpdateAreaDto(this CategoryRequestDto categoryDto)
		{
			return new Category
			{
				Name = categoryDto.Name,
				Updated_at = DateTime.Now
			};
		}
	}
}
