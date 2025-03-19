using JobFind_BE.DTOs.Account;
using JobFind_BE.Interfaces;
using JobFind_BE.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace JobFind_BE.Controllers
{
	[Route("api/v1/account")]
	[ApiController]
	public class AccountController : ControllerBase
	{
		private readonly UserManager<AppUser> _userManager;	
		private readonly ITokenService _tokenService;
		private readonly SignInManager<AppUser> _signInManager;
		public AccountController( UserManager<AppUser> userManager, ITokenService tokenService, SignInManager<AppUser> signInManager)
		{
			_userManager = userManager;
			_tokenService = tokenService;
			_signInManager = signInManager;
		}
		[HttpPost("register")]
		public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
		{
			try 
			{
				if(!ModelState.IsValid)
				{
					return BadRequest(ModelState);
				}
				var user = new AppUser
				{
					UserName = registerDto.Email,
					Email = registerDto.Email,
					PhoneNumber = registerDto.PhoneNumber
				};
				var register = await _userManager.CreateAsync(user, registerDto.Password);
				if (register.Succeeded)
				{
					var roleResult = await _userManager.AddToRoleAsync(user, "User");
					if (!roleResult.Succeeded)
					{
						return StatusCode(500, roleResult.Errors);
					}
					return Ok(new NewUserDto
					{
						UserName = user.UserName,
						Email = user.Email,
						Token = _tokenService.CreateToken(user)
					});
				}
				else
				{
					return BadRequest(register.Errors);
				}
			}
			catch (Exception e) 
			{
				return StatusCode(500, e.Message);
			}
		}
		[HttpPost("login")]
		public async Task<IActionResult> Login([FromBody] LoginDto loginDto )
		{
			if(!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			var user = await _userManager.FindByEmailAsync(loginDto.Email.ToLower());
			if (user == null)
			{
				return Unauthorized();
			}
			var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);
			if(!result.Succeeded)
			{
				return Unauthorized("Email hoặc Mật khẩu không chính xác !!!");
			}
			return Ok(new NewUserDto
			{
				UserName = user.UserName,
				Email = user.Email,
				Token = _tokenService.CreateToken(user)
			});
		}

	}
}
