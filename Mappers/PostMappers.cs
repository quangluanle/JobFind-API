using JobFind_BE.DTOs.Post;
using JobFind_BE.Models;
using Microsoft.VisualBasic;

namespace JobFind_BE.Mappers
{
	public static class PostMappers
	{
		public static PostDto toPostDto(this Post post)
		{
			return new PostDto
			{
				Id = post.Id,
				Title = post.Title,
				Description = post.Description,
				Status = post.Status,
				Company_id = post.Company_id,
				Area_id = post.Area_id,
				Due_at = post.Due_at,
				Benefit = post.Benefit,
				Form_of_work_id = post.Form_of_work_id,
				Amount = post.Amount,
				Salary = post.Salary,
				Category_id = post.Category_id,
				Created_at = post.Created_at,
				Updated_at = post.Updated_at,
			};
		}
		public static Post toPostFromPostDto(PostDto postDto)
		{
			return new Post
			{
				Title = postDto.Title,
				Description = postDto.Description,
				Status = postDto.Status,
				Company_id = postDto.Company_id,
				Area_id = postDto.Area_id,
				Due_at = postDto.Due_at,
				Benefit = postDto.Benefit,
				Form_of_work_id = postDto.Form_of_work_id,
				Amount = postDto.Amount,
				Salary = postDto.Salary,
				Category_id = postDto.Category_id,
				Created_at = postDto.Created_at,
				Updated_at = postDto.Updated_at,
			};
		}
	}
}
