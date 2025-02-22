using JobFind_BE.Data;
using JobFind_BE.DTOs.Post;
using JobFind_BE.Helpers;
using JobFind_BE.Interfaces;
using JobFind_BE.Models;
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
			var result = await _context.Posts.AddAsync(post);
			 _context.SaveChanges();
			return post;
		}

		public Task<Post?> DeletePost(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<Post>> GetAllPosts(PostQueryObject postQueryObject)
		{
			var posts = _context.Posts.Include(o => o.Areas).Include(o => o.Categories)
							.Include(o => o.Companies).Include(o => o.FormOfWorks)
							.Include(o => o.Post_Levels).Include(o => o.Post_Tags)
							.Include(o => o.post_Positions).AsQueryable();

			if (!string.IsNullOrWhiteSpace(postQueryObject.Level))
			{
				posts = posts.Where(p => p.Post_Levels.Any(pp => pp.Level.Name == postQueryObject.Level));
			}
			if (!string.IsNullOrWhiteSpace(postQueryObject.Tag))
			{
				posts = posts.Where(p => p.Post_Tags.Any(pp => pp.Tag.Name == postQueryObject.Tag));
			}
			if (!string.IsNullOrWhiteSpace(postQueryObject.Position))
			{
				posts = posts.Where(p => p.post_Positions.Any(pp => pp.Position.Name == postQueryObject.Position));
			}
			if (!string.IsNullOrWhiteSpace(postQueryObject.Company))
			{
				posts = posts.Where(o => o.Companies.Name.Contains(postQueryObject.Company));
			}
			if (!string.IsNullOrWhiteSpace(postQueryObject.Category))
			{
				posts = posts.Where(o => o.Categories.Name.Contains(postQueryObject.Category));
			}
			if (!string.IsNullOrWhiteSpace(postQueryObject.FormOfWork))
			{
				posts = posts.Where(o => o.FormOfWorks.Name.Contains(postQueryObject.FormOfWork));
			}
			if (!string.IsNullOrWhiteSpace(postQueryObject.Level))
			{
				posts = posts.Where(p => p.Post_Levels.Any(pp => pp.Level.Name == postQueryObject.Level));
			}
			if (!string.IsNullOrWhiteSpace(postQueryObject.SortBy))
			{
				if (postQueryObject.SortBy.Equals("Amount", StringComparison.OrdinalIgnoreCase))
				{
					posts = postQueryObject.IsSortAscending ? posts.OrderByDescending(s => s.Amount) : posts.OrderBy(s => s.Amount);
				}
			}
			var skipNumber = (postQueryObject.Page - 1) * postQueryObject.PageSize;

			return await posts.Skip(skipNumber).Take(postQueryObject.PageSize).ToListAsync();
		}

		public Task<Post?> GetPostById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<Post?> UpdatePost(int id, PostDto post)
		{
			throw new NotImplementedException();
		}
	}
}
