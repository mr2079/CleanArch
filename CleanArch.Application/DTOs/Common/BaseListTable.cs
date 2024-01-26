namespace CleanArch.Application.DTOs.Common;

public class BaseListTable<T> where T : class
{
	public List<T> Rows { get; set; } = new();
	public int Total { get; set; }
	public int TotalNotFiltered { get; set; }
	public bool HasMore { get; set; }
}