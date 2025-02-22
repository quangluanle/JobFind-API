using JobFind_BE.Data;
using JobFind_BE.DTOs.Area;
using JobFind_BE.Interfaces;
using JobFind_BE.Models;
using Microsoft.EntityFrameworkCore;

namespace JobFind_BE.Repository
{
	public class AreaRepository : IAreaRepository
	{
		private readonly ApplicationDBContext _context;
		public AreaRepository(ApplicationDBContext context)
		{
			_context = context;
		}

		public async Task<Area?> createArea(Area area)
		{
			await _context.Areas.AddAsync(area);
			await _context.SaveChangesAsync();
			return area;
		}

		public async Task<Area?> deleteArea(int id)
		{
			var area = await _context.Areas.FindAsync(id);
			if (area == null)
			{
				return null;
			}
			_context.Areas.Remove(area);
			await _context.SaveChangesAsync();
			return area;
		}

		public async Task<Area?> getAreaById(int id)
		{
			var area = await _context.Areas.FindAsync(id);
			if (area == null) {
				return null;
			}
			return area;
		}

		public async Task<bool?> existsAreas(string name)
		{
			var area = await _context.Areas.Where(a => EF.Functions.Like(a.Name, $"%{name}%")).FirstOrDefaultAsync();
			if (area == null)
			{
				return false;
			}
			return true;

		}

		public async Task<List<Area>> getAllAreas()
		{
			return  await _context.Areas.ToListAsync();
		}

		public async Task<Area?> updateArea(int id, AreaRequestDto area)
		{
			var areaModel = await _context.Areas.FindAsync(id);
			if (areaModel == null)
			{
				return null;
			}
			areaModel.Name = area.Name;
			areaModel.Updated_at = DateTime.Now;
			_context.Update(areaModel);
			await _context.SaveChangesAsync();
			return areaModel;
		}
	}
}
