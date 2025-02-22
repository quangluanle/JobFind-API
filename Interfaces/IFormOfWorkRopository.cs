using JobFind_BE.DTOs.FormOfWork;
using JobFind_BE.Models;

namespace JobFind_BE.Interfaces
{
	public interface IFormOfWorkRopository
	{
		Task<List<FormOfWork>> getAllFormOfWorks();
		Task<FormOfWork?> getFormOfWorkById(int id);
		Task<bool?> existsFormOfWork(string name);
		Task<FormOfWork?> createFormOfWork(FormOfWork formOfWork);
		Task<FormOfWork?> updateFormOfWork(FormOfWorkRequestDto formOfWork);
		Task<FormOfWork?> deleteFormOfWork(int id); 



	}
}
