using JobFind_BE.DTOs.FormOfWork;
using JobFind_BE.Models;

namespace JobFind_BE.Mappers
{
	public static class FormOfWorkMappers
	{
		public static FormOfWorkDto toFormOfWorkDto(this FormOfWork formOfWorkModel)
		{
			return new FormOfWorkDto
			{
				Id = formOfWorkModel.Id,
				Name = formOfWorkModel.Name,
				Description = formOfWorkModel.Description,
				Created_at = formOfWorkModel.Created_at,
				Updated_at = formOfWorkModel.Updated_at
			};
		}
	}
}
