using JobFind_BE.Interfaces;
using Microsoft.AspNetCore.Mvc;
using JobFind_BE.Mappers;

namespace JobFind_BE.Controllers
{
	[Route("api/v1/FormOfWork")]
	[ApiController]
	public class FormOfWorkController : ControllerBase
	{
		private readonly IFormOfWorkRopository _formOfWorkRepository;
		public FormOfWorkController(IFormOfWorkRopository formOfWorkRepository)
		{
			this._formOfWorkRepository = formOfWorkRepository;
		}
		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var form_of_works = await _formOfWorkRepository.getAllFormOfWorks();
			var form_of_work_dtos = form_of_works.Select(a => a.toFormOfWorkDto());
			return Ok(form_of_work_dtos);
		}
	}
}
