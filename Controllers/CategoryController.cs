using JobFind_BE.DTOs.Category;
using JobFind_BE.Interfaces;
using JobFind_BE.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace JobFind_BE.Controllers
{
	[Route("api/v1/category")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		private readonly ICategoryReposity _categoryRepository;
		public CategoryController(ICategoryReposity categoryRepository)
		{
			_categoryRepository = categoryRepository;
		}
		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var categories = await _categoryRepository.getAllCategories();
			var categoryDto = categories.Select(c => c.toCategoryDto());
			return Ok(categoryDto);
		}
		[HttpGet("{id:int}")]
		public async Task<IActionResult> GetById([FromRoute] int id)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			var category = await _categoryRepository.getCategoryById(id);
			if (category == null)
			{
				return NotFound();
			}
			return Ok(category.toCategoryDto());
		}
		[HttpPost]
		public async Task<IActionResult> Create([FromBody] CategoryRequestDto categoryRequest)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			var existingCategory = await _categoryRepository.existsCategory(categoryRequest.Name);
			if (existingCategory == true)
			{
				return Conflict("Danh mục đã tồn tại !!!");
			}
			var categoryModel = categoryRequest.toCategoryFromCreateAreaDto();
			await _categoryRepository.createCategory(categoryModel);
			return CreatedAtAction(nameof(GetById), new { id = categoryModel.Id }, categoryModel.toCategoryDto());
		}
		[HttpPut]
		[Route("{id:int}")]
		public async Task<IActionResult> Update([FromRoute] int id, [FromBody] CategoryRequestDto categoryRequest)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			var existingCategory = await _categoryRepository.existsCategory(categoryRequest.Name);
			if (existingCategory == true)
			{
				return Conflict("Khu vực đã tồn tại !!!");
			}
			var categoryModel = await _categoryRepository.updateCategory(id, categoryRequest);
			if (categoryModel == null)
			{
				return NotFound();
			}
			return Ok(categoryModel.toCategoryDto());
		}
		[HttpDelete]
		[Route("{id:int}")]
		public async Task<IActionResult> Delete([FromRoute] int id)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			var category = await _categoryRepository.deleteCategory(id);
			if (category == null)
			{
				return NotFound();
			}
			return Ok(category.toCategoryDto());
		}

	}
}
