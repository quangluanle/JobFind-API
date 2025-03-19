using JobFind_BE.Data;
using JobFind_BE.DTOs.Category;
using JobFind_BE.Interfaces;
using JobFind_BE.Models;
using Microsoft.EntityFrameworkCore;

namespace JobFind_BE.Repository
{
	public class CategoryReposity : ICategoryReposity
	{
		private readonly ApplicationDBContext _context;
		public CategoryReposity(ApplicationDBContext context)
		{
			_context = context;
		}
		public async Task<Category?> createCategory(Category category)
		{
			await _context.Category.AddAsync(category);
			await _context.SaveChangesAsync();
			return category;
		}

		public async Task<Category?> deleteCategory(int id)
		{
			var category = await _context.Category.FindAsync(id);
			if (category == null)
			{
				return null;
			}
			_context.Category.Remove(category);
			await _context.SaveChangesAsync();
			return category;
		}

		public async Task<bool?> existsCategory(string name)
		{
			var category = await _context.Category.Where(a => EF.Functions.Like(a.Name, $"%{name}%")).FirstOrDefaultAsync();
			if (category == null)
			{
				return false;
			}
			return true;
		}

		public async Task<List<Category>> getAllCategories()
		{
			return await _context.Category.ToListAsync();
		}

		public async Task<Category?> getCategoryById(int id)
		{
			var category = await _context.Category.FindAsync(id);
			if (category == null)
			{
				return null;
			}
			return category;
		}

		public async Task<Category?> updateCategory(int id, CategoryRequestDto category)
		{
			var exitsCategory = await _context.Category.FindAsync(id);
			if (exitsCategory == null)
			{
				return null;
			}
			exitsCategory.Name = category.Name;
			exitsCategory.Updated_at = DateTime.Now;
			_context.Update(exitsCategory);
			await _context.SaveChangesAsync();
			return exitsCategory;
		}
	}
}
