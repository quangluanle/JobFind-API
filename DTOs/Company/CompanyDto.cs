﻿namespace JobFind_BE.DTOs.Company
{
	public class CompanyDto
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public string Logo { get; set; } = string.Empty;
	}
}
