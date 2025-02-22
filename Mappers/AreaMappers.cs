using JobFind_BE.Models;
using JobFind_BE.DTOs.Area;

namespace JobFind_BE.Mappers
{
	public static class AreaMappers
	{
		public static AreaDto toAreaDto(this Area areaModel)
		{
			return new AreaDto
			{
				Id = areaModel.Id,
				Name = areaModel.Name,
				Created_at = areaModel.Created_at,
				Updated_at = areaModel.Updated_at
			};
		}
		public static Area toAreaFromCreateAreaDto(this AreaRequestDto createAreaDto)
		{
			return new Area
			{
				Name = createAreaDto.Name,
				Created_at = DateTime.Now,
				Updated_at = DateTime.Now
			};
		}
		public static Area toAreaFromUpdateAreaDto(this AreaRequestDto createAreaDto)
		{
			return new Area
			{
				Name = createAreaDto.Name,
				Updated_at = DateTime.Now
			};
		}
	}
}
