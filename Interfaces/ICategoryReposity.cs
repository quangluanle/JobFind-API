using JobFind_BE.DTOs.Category;
using JobFind_BE.Models;

namespace JobFind_BE.Interfaces
{
	public interface ICategoryReposity
	{
		public Task<List<Category>> getAllCategories();
		public Task<Category?> getCategoryById(int id);
		public Task<Category?> createCategory(Category category);
		Task<Category?> updateCategory(int id, CategoryRequestDto category);
		Task<Category?> deleteCategory(int id);
		Task<bool?> existsCategory(string name);
	}
}
