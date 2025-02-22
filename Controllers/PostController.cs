﻿using JobFind_BE.Helpers;
using JobFind_BE.Interfaces;
using JobFind_BE.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace JobFind_BE.Controllers
{
	public class PostController : ControllerBase
	{
		private readonly IPostRepository _postRepository;
		public PostController(IPostRepository postRepository)
		{
			_postRepository = postRepository;
		}
		[HttpGet]
		[Route("api/v1/post")]
		public async Task<IActionResult> GetAll([FromQuery] PostQueryObject postQuery)
		{
			var posts = await _postRepository.GetAllPosts(postQuery);
			var postDtos = posts.Select(a => a.toPostDto());
			return Ok(posts);
		}
	}
}
 