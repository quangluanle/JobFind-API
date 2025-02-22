using JobFind_BE.DTOs.Area;
using JobFind_BE.Interfaces;
using JobFind_BE.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace JobFind_BE.Controllers
{
	[Route("api/v1/area")]
	[ApiController]
	public class AreaController : ControllerBase
	{
		private readonly IAreaRepository _areaRepository;
		public AreaController(IAreaRepository areaRepository)
		{
			_areaRepository = areaRepository;
		}
		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var areas = await _areaRepository.getAllAreas();
			var areaDto = areas.Select(a => a.toAreaDto());
			return Ok(areaDto);
		}
		[HttpGet("{id:int}")]
		public async Task<IActionResult> GetById([FromRoute] int id)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			var area = await _areaRepository.getAreaById(id);
			if (area == null)
			{
				return NotFound();
			}
			return Ok(area.toAreaDto());
		}
		[HttpPost]
		public async Task<IActionResult> Create([FromBody] AreaRequestDto areaRequest)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			var existingArea = await _areaRepository.existsAreas(areaRequest.Name);
			if (existingArea == true)
			{
				return Conflict("Khu vực đã tồn tại !!!");
			}
			var areaModel = areaRequest.toAreaFromCreateAreaDto();
			await _areaRepository.createArea(areaModel);
			return CreatedAtAction(nameof(GetById), new { id = areaModel.Id }, areaModel.toAreaDto());
		}
		[HttpPut]
		[Route("{id:int}")]
		public async Task<IActionResult> Update([FromRoute] int id,[FromBody] AreaRequestDto areaRequest)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			var existingArea = await _areaRepository.existsAreas(areaRequest.Name);
			if (existingArea == true)
			{
				return Conflict("Khu vực đã tồn tại !!!");
			}
			var areaModel =  await _areaRepository.updateArea(id, areaRequest);
			if (areaModel == null)
			{
				return NotFound("Không tìm thấy khu vực !!!");
			}			
			return Ok(areaModel.toAreaDto());
		}
		[HttpDelete]
		[Route("{id:int}")]
		public async Task<IActionResult> Delete([FromRoute] int id)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			var areaModel = await _areaRepository.deleteArea(id);
			if (areaModel == null)
			{
				return NotFound();
			}
			return NoContent();
		}
	}
}