using JobFind_BE.Data;
using JobFind_BE.DTOs.Area;
using JobFind_BE.DTOs.Category;
using JobFind_BE.DTOs.Company;
using JobFind_BE.DTOs.FormOfWork;
using JobFind_BE.DTOs.Post;
using JobFind_BE.Helpers;
using JobFind_BE.Interfaces;
using JobFind_BE.Mappers;
using JobFind_BE.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace JobFind_BE.Repository
{
	public class PostRepository : IPostRepository
	{
		private readonly ApplicationDBContext _context;
		public PostRepository(ApplicationDBContext context)
		{
			this._context = context;
		}

		public async Task<Post?> CreatePost(Post post)
		{
			_context.Post.Add(post);
			await _context.SaveChangesAsync();
			return post;
		}

		public async Task<Post?> DeletePost(int id)
		{
			var post = await _context.Post.FindAsync(id);
			if (post == null) return null;

			post.Status = "Deleted";
			await _context.SaveChangesAsync();
			return post;
		}

		public async Task<PaginatedResult<PostDto>> GetAllPosts(int pageSize, int page, string? search)
		{
			var query = _context.Post.AsQueryable();

			if (!string.IsNullOrEmpty(search))
			{
				query = query.Where(p =>
					p.Title.Contains(search) ||
					p.Description.Contains(search) ||
					p.Status.Contains(search) ||
					p.Benefit.Contains(search));
			}

			var totalRecords = await query.CountAsync();

			var posts = await query
				.OrderByDescending(p => p.Created_at)
				.Skip((page - 1) * pageSize)
				.Take(pageSize)
				.Select(p => new PostDto
				{
					Id = p.Id,
					Title = p.Title,
					Status = p.Status,
					Salary = p.Salary,
					Amount = p.Amount,
					Due_at = p.Due_at,
					Company = new CompanyDto { Id = p.Company.Id, Name = p.Company.Name, Logo = p.Company.Logo , Description = p.Company.Description},
					Area = new AreaDto { Id = p.Area.Id, Name = p.Area.Name },
					FormOfWork = new FormOfWorkDto { Id = p.FormOfWork.Id, Name = p.FormOfWork.Name },
					Category = new CategoryDto { Id = p.Category.Id, Name = p.Category.Name },
					//Tags = p.Post_Tags.Select(pt => new TagDto { Id = pt.Id, Name = pt.Tag.Name }).ToList(),
					//Levels = p.Post_Levels.Select(pl => new LevelDto { Id = pl.Id, Name = pl.Level.Name }).ToList(),
					//Positions = p.post_Positions.Select(pp => new PositionDto { Id = pp.Id, Name = pp.Position.Name }).ToList(),
					//Users = p.post_users.Select(pu => new UserDto { Id = pu.Id, UserName = pu.User.Name }).ToList()
				})
				.ToListAsync();

			return new PaginatedResult<PostDto>(posts, totalRecords, pageSize, page);
		}

		public Task<Post?> GetPostById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<List<Post>> GetPostsByArea(int areaId)
		{
			throw new NotImplementedException();
		}

		public async Task<List<Post>> GetPostsByCategory(int categoryId)
		{
			return await _context.Post.Where(p => p.Category_id == categoryId).ToListAsync();
		}

		public async Task<List<Post>> GetPostsByCompany(int companyId)
		{
			return await _context.Post.Where(p => p.Company_id == companyId).ToListAsync();
		}

		public Task<List<Post>> GetPostsByTag(int tagId)
		{
			throw new NotImplementedException();
		}

		public async Task<List<Post>> GetTopNewestPosts(int limit)
		{
			return await _context.Post.OrderByDescending(p => p.Created_at).Take(limit).ToListAsync();
		}

		public async Task<Post?> UpdatePost(int id, PostDto updatedPost)
		{
			var post = await _context.Post.FindAsync(id);
			if (post == null)
				return null;

			post.Title = updatedPost.Title;
			post.Description = updatedPost.Description;
			post.Status = updatedPost.Status;
			post.Benefit = updatedPost.Benefit;
			post.Salary = updatedPost.Salary;

			await _context.SaveChangesAsync();
			return post;
		}
	
	}
}
