using Microsoft.EntityFrameworkCore;

namespace JobFind_BE.Helpers
{
	public class PaginatedResult<T>
	{
		private List<object> posts;
		private int totalRecords;

		public List<T> Data { get; }
		public int Page { get; }
		public int PageSize { get; }
		public int TotalCount { get; }

		public PaginatedResult(List<T> items, int count, int page, int pageSize)
		{
			Data = items;
			TotalCount = count;
			Page = page;
			PageSize = pageSize;
		}

		public PaginatedResult(List<object> posts, int totalRecords, int pageSize, int page)
		{
			this.posts = posts;
			this.totalRecords = totalRecords;
			PageSize = pageSize;
			Page = page;
		}

		public static async Task<PaginatedResult<T>> CreateAsync(IQueryable<T> query, int page, int pageSize)
		{
			var count = await query.CountAsync();
			var items = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
			return new PaginatedResult<T>(items, count, page, pageSize);
		}
	}
}
