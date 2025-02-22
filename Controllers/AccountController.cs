using JobFind_BE.DTOs.Account;
using JobFind_BE.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace JobFind_BE.Controllers
{
	[Route("api/v1/account")]
	[ApiController]
	public class AccountController : ControllerBase
	{
		private readonly UserManager<AppUser> _userManager;	
		public AccountController( UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}
		[HttpPost]
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
					UserName = registerDto.Username,
					Email = registerDto.Email,
					PhoneNumber = registerDto.PhoneNumber
				};
				var register = await _userManager.CreateAsync(user, registerDto.Password);
				if (register.Succeeded)
				{
					return Ok("Đăng ký thành công !!!");
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

	}
}
