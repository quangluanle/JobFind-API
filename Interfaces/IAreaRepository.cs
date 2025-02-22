using JobFind_BE.DTOs.Area;
using JobFind_BE.Models;

namespace JobFind_BE.Interfaces
{
	public interface IAreaRepository
	{
		Task<List<Area>> getAllAreas();
		Task<Area?> getAreaById(int id);
		Task<bool?> existsAreas(string name);
		Task<Area?> createArea(Area area);
		Task<Area?> updateArea(int id, AreaRequestDto area);
		Task<Area?> deleteArea(int id);

	}
}
