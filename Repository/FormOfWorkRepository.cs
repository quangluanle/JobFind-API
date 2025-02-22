using JobFind_BE.Data;
using JobFind_BE.DTOs.FormOfWork;
using JobFind_BE.Interfaces;
using JobFind_BE.Models;
using Microsoft.EntityFrameworkCore;

namespace JobFind_BE.Repository
{
	public class FormOfWorkRepository : IFormOfWorkRopository
	{
		private readonly ApplicationDBContext _context;
		public FormOfWorkRepository(ApplicationDBContext context) 
		{
			this._context = context;
		}
		public async Task<FormOfWork?> createFormOfWork(FormOfWork formOfWork)
		{
			var result = await _context.FormOfWorks.AddAsync(formOfWork);
			await _context.SaveChangesAsync();
			return formOfWork;
		}

		public Task<FormOfWork?> deleteFormOfWork(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<bool?> existsFormOfWork(string name)
		{
			var form_of_work = await _context.FormOfWorks.Where(a => EF.Functions.Like(a.Name, $"%{name}%")).FirstOrDefaultAsync();
			if (form_of_work == null)
			{
				return false;
			}
			return true;
		}

		public async Task<List<FormOfWork>> getAllFormOfWorks()
		{
			return await _context.FormOfWorks.ToListAsync();
		}

		public Task<FormOfWork?> getFormOfWorkById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<FormOfWork?> updateFormOfWork(FormOfWorkRequestDto formOfWork)
		{
			throw new NotImplementedException();
		}
	}
}
