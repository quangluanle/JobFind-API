namespace JobFind_BE.Helpers
{
	public class PostQueryObject
	{
		public string? Title { get; set; }
		public string? Company { get; set; }
		public string? Area { get; set; }
		public string? FormOfWork { get; set; }
		public string? Category { get; set; }
		public string? Level { get; set; }
		public string? Position { get; set; }
		public string? Tag { get; set; }
		public string? SortBy { get; set; }
		public bool IsSortAscending { get; set; }
		public int Page { get; set; } = 1;
		public byte PageSize { get; set; } = 20;
	}
}
