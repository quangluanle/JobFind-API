using JobFind_BE.DTOs.Company;
using JobFind_BE.DTOs.Post;
using JobFind_BE.Models;
using Microsoft.VisualBasic;

namespace JobFind_BE.Mappers
{
	public static class CompanyMappers
	{
		public static CompanyDto toCompanyDto(this Company company)
		{
			return new CompanyDto
			{
				Id = company.Id,
				Name = company.Name,
				Description = company.Description,
				Logo = company.Logo,
			};
		}
		public static Company toPostFromPostDto(CompanyDto companyDto)
		{
			return new Company
			{
				Name = companyDto.Name,
				Description = companyDto.Description,
				Logo = companyDto.Logo,
			};
		}
	}
}
