using JobFind_BE.DTOs.Post;
using JobFind_BE.Helpers;
using JobFind_BE.Models;

namespace JobFind_BE.Interfaces
{
	public interface IPostRepository
	{
		Task<List<Post>> GetAllPosts(PostQueryObject postQueryObject);
		Task<Post?> GetPostById(int id);
		Task<Post?> CreatePost(Post post);
		Task<Post?> UpdatePost(int id, PostDto post);
		Task<Post?> DeletePost(int id);
	}
}
