using JobFind_BE.DTOs.Post;
using JobFind_BE.Helpers;
using JobFind_BE.Models;

namespace JobFind_BE.Interfaces
{
	public interface IPostRepository
	{
		Task<PaginatedResult<PostDto>> GetAllPosts(int pageSize, int page, string? search);
		Task<Post?> GetPostById(int id);
		Task<Post?> CreatePost(Post post);
		Task<Post?> UpdatePost(int id, PostDto post);
		Task<Post?> DeletePost(int id);
		Task<List<Post>> GetPostsByCategory(int categoryId);
		Task<List<Post>> GetPostsByCompany(int companyId);
		Task<List<Post>> GetPostsByArea(int areaId);
		Task<List<Post>> GetPostsByTag(int tagId);
		Task<List<Post>> GetTopNewestPosts(int limit);
	}
}
